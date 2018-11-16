using System;

namespace DITutorial.OldAndBadWay
{
    public class CustomerProcessor
    {
        public void UpdateCustomerOrder(
            string orderCustomerName,
            string orderProduct)
        {
            var customerRepository = new CustomerRepository();
            var productRepository = new ProductRepository();

            customerRepository.Save();
            productRepository.Save();

            Console.WriteLine($"Customer {orderCustomerName} updated with purchase for {orderProduct}");
        }
    }
}