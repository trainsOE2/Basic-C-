using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach( var str in  numbers)
            {
                var currNum = Convert.ToInt32(str);
                if (max < currNum)
                    max = currNum;
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
