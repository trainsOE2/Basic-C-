using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroConstructor
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadKey();
        }
    }
}
