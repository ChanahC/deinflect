using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeinflectLibrary;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            sase x = new sase();
            Console.WriteLine("Input your jap string in form");
            string input = Console.ReadLine();
            Console.WriteLine("Answer\n");
            List<string> xx = x.inflect(input);
            foreach (string a in xx)
            {
                Console.WriteLine(a);
            }
        }
    }
}
