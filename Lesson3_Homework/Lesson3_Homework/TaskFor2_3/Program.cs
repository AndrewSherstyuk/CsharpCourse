using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's you name?");

            string hi = "Привет, ";

            string name = Console.ReadLine();

            Console.WriteLine(String.Concat(hi, name, "!"));

            Console.WriteLine($"{hi}{name}!");

            Console.WriteLine("{0}{1}!", hi, name);

            Console.WriteLine(hi += name);

            Console.ReadKey();
        }
    }
}
