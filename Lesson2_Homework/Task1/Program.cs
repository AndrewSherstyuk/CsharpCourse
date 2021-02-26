using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of meters");

            string meters = Console.ReadLine();

            int centimeters = int.Parse(meters) * 100;

            Console.WriteLine("There are {0} centimeters in {1} meters", centimeters, meters);

            Console.ReadKey();
        }
    }
}
