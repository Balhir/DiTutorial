using System;

namespace DITutorial.OldAndBadWay
{
    public class OrderProcessor
    {
        public void ProcessOrder(OrderInfo order)
        {
            var customerProcessor = new CustomerProcessor();
            var billingProcessor = new BillingProcessor();
            var notifier = new Notifier();

            billingProcessor.ProcessPayment(order.CustomerName, order.CreditCardNumber, order.Amount);
            customerProcessor.UpdateCustomerOrder(order.CustomerName, order.Product);
            notifier.SendReceipt(order);

            Console.WriteLine("Processing done!");
        }
    }
}