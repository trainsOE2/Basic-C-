
using System;
using System.IO;

namespace readWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            FileStream file = new FileStream("D:/C#/readWrite/data.txt", FileMode.OpenOrCreate);
            StreamReader stream = new StreamReader(file);
            line = stream.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = stream.ReadLine();
            }

            stream.Close();
            Console.ReadKey();

        }
    }
}
