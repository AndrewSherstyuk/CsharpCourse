using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the cylinder radius");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the cylinder height");
            double h = double.Parse(Console.ReadLine());

            double v = Math.PI * Math.Pow(r, 2) * h;

            double s = 2 * Math.PI * r * (r + h);
            Console.WriteLine($"The cylinder volume equals to { Math.Round(v, 2) } \nThe cylinder square equals to { Math.Round(s, 2) }");

            Console.ReadKey();
        }
    }
}
