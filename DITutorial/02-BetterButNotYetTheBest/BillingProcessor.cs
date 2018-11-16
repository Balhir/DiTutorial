using System;

namespace DITutorial.BetterButNotYetTheBest
{
    public interface IBillingProcessor
    {
        void ProcessPayment(
            string orderCustomerName,
            string orderCreditCardNumber,
            int orderAmount);
    }

    public class BillingProcessor : IBillingProcessor
    {
        public void ProcessPayment(
            string orderCustomerName,
            string orderCreditCardNumber,
            int orderAmount)
        {
            Console.WriteLine($"Processing payment for {orderCustomerName} on credit card {orderCreditCardNumber} for ${orderAmount}");
        }
    }
}