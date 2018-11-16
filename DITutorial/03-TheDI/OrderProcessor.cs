using System;

namespace DITutorial.TheDI
{
    public interface IOrderProcessor
    {
        void ProcessOrder(OrderInfo order);
    }

    public class OrderProcessor : IOrderProcessor
    {
        private readonly ICustomerProcessor _customerProcessor;
        private readonly IBillingProcessor _billingProcessor;
        private readonly INotifier _notifier;

        public OrderProcessor(
            ICustomerProcessor customerProcessor,
            IBillingProcessor billingProcessor,
            INotifier notifier)
        {
            _customerProcessor = customerProcessor;
            _billingProcessor = billingProcessor;
            _notifier = notifier;
        }

        public void ProcessOrder(OrderInfo order)
        {
            _billingProcessor.ProcessPayment(order.CustomerName, order.CreditCardNumber, order.Amount);
            _customerProcessor.UpdateCustomerOrder(order.CustomerName, order.Product);
            _notifier.SendReceipt(order);

            Console.WriteLine("Processing done!");
        }
    }
}