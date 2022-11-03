using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class CustomerRegister
    {
        private static List<Customer> customersList = new List<Customer>();

        public static void AddCustomerToList(Customer customer)
        {
            customersList.Add(customer);
        }

        public static void PrintCustomerList()
        {
            foreach(Customer customer in customersList)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public static void RemoveCustomerFromList(Customer customer)
        {
            Console.WriteLine($"{customer} : has been removed from customer list");
            customersList.Remove(customer);
        }
    }
}
