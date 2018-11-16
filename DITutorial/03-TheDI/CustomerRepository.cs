using System;

namespace DITutorial.TheDI
{
    public interface ICustomerRepository
    {
        void Save();
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void Save()
        {
            Console.WriteLine("CustomerRepository - Save called");
        }
    }
}