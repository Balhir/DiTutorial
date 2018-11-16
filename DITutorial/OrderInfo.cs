using System;

namespace DITutorial
{
    public class OrderInfo
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public string CreditCardNumber { get; set; }
    }
}