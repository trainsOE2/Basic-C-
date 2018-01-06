using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Autobots";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
