using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Pizza
    {
        private static int nextId = 1;

        public string PizzaName { get; set; }
        public string Topping { get; set; }
        public double PizzaPrice { get; set; }
        public int PizzaId { get; set; }

        public Pizza(string pizzaName, string topping, double pizzaPrice)
        {
            PizzaName = pizzaName;
            Topping = topping;
            PizzaPrice = pizzaPrice;
            PizzaId = nextId++;
            Menu.AddPizzaToMenu(this);
        }

        public override string ToString()
        {
            return $"{nameof(PizzaName)}: {PizzaName}  {nameof(Topping)}: {Topping}  {nameof(PizzaPrice)}:{PizzaPrice.ToString()}  {nameof(PizzaId)}:{PizzaId.ToString()}";
        }
    }
}
