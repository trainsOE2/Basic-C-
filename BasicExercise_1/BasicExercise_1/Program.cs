using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var count = 0;
            while ( i < 100)
            {
                if (i%3 == 0)
                {
                    count++;
                }
                i++;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
