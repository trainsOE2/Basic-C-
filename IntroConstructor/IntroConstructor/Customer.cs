using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroConstructor
{

    class Customer
    {
        public string Name;
        public int Id;
        public List<Order> Orders;
        
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
