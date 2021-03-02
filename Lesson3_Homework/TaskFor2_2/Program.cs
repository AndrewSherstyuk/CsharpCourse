using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the circle length. If the number is fractional, use comma as decimal point");

            double pi = 3.14;
            
            double l = Convert.ToDouble(Console.ReadLine());

            double r = Math.Round((l / (2 * pi)), 2);

            double s = Math.Round((pi * Math.Pow(r, 2)), 2);

            Console.WriteLine($"\nThe radius of the circle equals to {r} \nThe square of the circle equals to {s}");

            Console.ReadKey();
        }
    }
}
