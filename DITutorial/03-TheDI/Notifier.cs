using System;

namespace DITutorial.TheDI
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo order);
    }

    public class Notifier : INotifier
    {
        public void SendReceipt(OrderInfo order)
        {
            Console.WriteLine($"Sending receipt for purchasing {order.Product} to {order.CustomerEmail}");
        }
    }
}