using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    class Person
    {
        public string name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Megha") ;
            person.Introduce("Mosh");
            Console.ReadKey();

        }
    }
}
