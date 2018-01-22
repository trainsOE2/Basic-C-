using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*using MarkdownLog;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;*/

namespace CSVtest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String st = System.IO.File.ReadAllText("C:\\Users/ADMIN/Documents/Visual Studio 2015/Projects/CSVtest/CSVtest/File.csv");
                Console.WriteLine(st);
            }

            catch( Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
