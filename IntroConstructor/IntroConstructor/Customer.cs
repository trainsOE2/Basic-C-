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

        /*void Customer(string name)
        {
            this.Name = name;
        }*/

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
