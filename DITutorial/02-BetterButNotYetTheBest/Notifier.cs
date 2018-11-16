using System;

namespace DITutorial.BetterButNotYetTheBest
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