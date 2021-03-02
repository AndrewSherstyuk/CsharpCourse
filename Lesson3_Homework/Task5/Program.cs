using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Start: 
            
            double x1, x2, d;
            
            Console.WriteLine("\nPlease enter a value for \'a\'");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a value for \'b\'");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a value for \'c\'");

            double c = Convert.ToDouble(Console.ReadLine());

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
            else if (d == 0)
            {
                x1 = -(b / (2 * a));

                Console.WriteLine($"There's 1 root existing for the equation. X equals to {x1}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);

                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"There are 2 roots existing forthe equation. X1 equals to {x1}, X2 equals to {x2}");
            }

            goto Start;
        }
    }
}
