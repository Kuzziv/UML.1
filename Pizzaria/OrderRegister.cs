using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class OrderRegister
    {
        private static List<Order> orderList = new List<Order>();

        public static void AddOrderToList(Order order)
        {
            orderList.Add(order);
        }

        public static void PrintOrderList()
        {
            foreach (Order order in orderList)
            {
                Console.WriteLine(order);
            }
        }

        public static void RemoveOrderFromList(Order order)
        {
            Console.WriteLine($"{order} : has been removed from order list");
            orderList.Remove(order);
        }

    }
}
