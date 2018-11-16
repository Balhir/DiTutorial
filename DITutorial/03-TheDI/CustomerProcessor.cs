using System;

namespace DITutorial.TheDI
{
    public interface ICustomerProcessor
    {
        void UpdateCustomerOrder(string orderCustomerName, string orderProduct);
    }
    
    public class CustomerProcessor : ICustomerProcessor
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        
        public CustomerProcessor(
            IProductRepository productRepository,
            ICustomerRepository customerRepository)
        {
            _productRepository = productRepository;
            _customerRepository = customerRepository;
        }

        public void UpdateCustomerOrder(string orderCustomerName, string orderProduct)
        {
            _customerRepository.Save();
            _productRepository.Save();

            Console.WriteLine($"Customer {orderCustomerName} updated with purchase for {orderProduct}");
        }
    }
}