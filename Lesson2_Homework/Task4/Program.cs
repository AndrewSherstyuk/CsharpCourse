using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;

            Console.WriteLine("Please enter the angle value in degrees");

            double degrees = double.Parse(Console.ReadLine());

            double radians = degrees * pi / 180;

            Console.WriteLine("The sin of the angle equals to {0}", Math.Sin(radians));

            Console.ReadKey();
        }
    }
}
