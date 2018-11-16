using System;

namespace DITutorial.OldAndBadWay
{
    public class BillingProcessor
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