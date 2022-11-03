using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Order
    {
        private int nextId = 1;
        public Customer Customer { get; set; }
        public Pizza Pizza { get; set; }
        public int OrderId { get; set; }

        public Order(Customer customer, Pizza pizza)
        {
            Pizza = pizza;
            Customer = customer;
            OrderId = nextId++;
            OrderRegister.AddOrderToList(this);
        }

        public override string ToString()
        {
            return $"{nameof(Customer)}:{Customer}  {nameof(Pizza)}:{Pizza}  {nameof(OrderId)}:{OrderId.ToString()}";
        }
    }
}
