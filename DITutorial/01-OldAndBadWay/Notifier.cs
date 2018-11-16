using System;

namespace DITutorial.OldAndBadWay
{
    public class Notifier
    {
        public void SendReceipt(OrderInfo order)
        {
            Console.WriteLine($"Sending receipt for purchasing {order.Product} to {order.CustomerEmail}");
        }
    }
}