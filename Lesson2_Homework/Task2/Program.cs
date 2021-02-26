using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;

            Console.WriteLine("Please enter the circle radius");

            double radius = double.Parse(Console.ReadLine());

            double square = (Math.Pow(radius, 2)) * pi;

            Console.WriteLine("The circle square is {0}", Math.Round(square, 2));

            Console.ReadKey();
        }
    }
}
