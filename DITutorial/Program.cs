using SimpleInjector;
using System;

namespace DITutorial
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                #region Usage
                Console.WriteLine(@"
                Choose demo:
                1 - old ugly way
                2 - better but not yet the best
                3 - The DI!");
                Console.Write("Select demo:");
                var demoLevel = int.Parse(Console.ReadLine());
                #endregion
                var order = new OrderInfo
                {
                    CustomerName = "Maciej Lewandowski",
                    CustomerEmail = "maciej.lewandowski@outlook.com",
                    Product = "Laptop Dell 6000",
                    Amount = 1200,
                    CreditCardNumber = "123412341234",
                    OrderDate = DateTime.Now
                };

                switch (demoLevel)
                {
                    case 1:
                    {
                        #region The old & bad way

                        var orderProcessor = new OldAndBadWay.OrderProcessor();
                        orderProcessor.ProcessOrder(order);

                        #endregion
                        break;
                    }
                    case 2:
                    {
                        #region Better but not yet the best

                        var orderProcessorWithInterface =
                            new BetterButNotYetTheBest.OrderProcessor(
                                new BetterButNotYetTheBest.CustomerProcessor(
                                    new BetterButNotYetTheBest.ProductRepository(),
                                    new BetterButNotYetTheBest.CustomerRepository()
                                ),
                                new BetterButNotYetTheBest.BillingProcessor(),
                                new BetterButNotYetTheBest.Notifier());

                        orderProcessorWithInterface.ProcessOrder(order);

                        #endregion
                        break;
                    }
                    case 3:
                    {
                        #region The DI

                        var container = new Container();
                        container.RegisterSingleton<TheDI.ICustomerRepository, TheDI.CustomerRepository>();
                        container.RegisterSingleton<TheDI.IProductRepository, TheDI.ProductRepository>();
                        container.RegisterSingleton<TheDI.IBillingProcessor, TheDI.BillingProcessor>();
                        container.RegisterSingleton<TheDI.ICustomerProcessor, TheDI.CustomerProcessor>();
                        container.RegisterSingleton<TheDI.INotifier, TheDI.Notifier>();
                        container.RegisterSingleton<TheDI.IOrderProcessor, TheDI.OrderProcessor>();

                        var orderProcessFromDi = container.GetInstance<TheDI.IOrderProcessor>();
                        orderProcessFromDi.ProcessOrder(order);

                        #endregion
                        break;
                    }
                    default:
                    {
                        return;
                    }
                }
            }
        }
    }
}
