using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Customer
    {
        private int nextId = 1;

        public string Name { get; set; }
        public int CustomerId { get; set; }


        public Customer(string name)
        {
            Name = name;
            CustomerId = nextId++;
            CustomerRegister.AddCustomerToList(this);
        }

        public override string ToString()
        {
            return $" {nameof(Name)}:{Name}  {nameof(CustomerId)}:{CustomerId.ToString()}";
        }
    }
}
