using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var randNum = new Random().Next(1, 25);
            Console.WriteLine(randNum);

            for (var i=0; i<4; i++)
            {
                Console.WriteLine("Guess {0}", i+1);
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randNum)
                {
                    Console.WriteLine("You Won!");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("You have lost!");
            Console.ReadKey();
        }
    }
}
