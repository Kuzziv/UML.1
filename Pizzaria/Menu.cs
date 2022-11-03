using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Menu
    {
        private static List<Pizza> menuList = new List<Pizza>();


        public static void AddPizzaToMenu(Pizza pizza)
        {
            menuList.Add(pizza);
        }


        public static void PrintMenu()
        {
            foreach (Pizza pizza in menuList)
            {
                Console.WriteLine(pizza);
            }
        }

        public static void RemovePizzaFromMenu(Pizza pizza)
        {
            Console.WriteLine($"{pizza} : has been removed from menu");
            menuList.Remove(pizza);
        }
    }
}
