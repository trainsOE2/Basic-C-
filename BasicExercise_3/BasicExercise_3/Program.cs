using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fact = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            var multiplier = 1;
            for (multiplier = 1; multiplier <= fact; multiplier++)
            {
                factorial = factorial*multiplier;
            }
            Console.WriteLine("{0}! = {1}", fact, factorial);
            Console.ReadKey();
        }
    }
}
