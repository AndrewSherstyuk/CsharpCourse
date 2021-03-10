using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("Please enter the width of the rectangle, use comma as the decimal point: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Please enter the height of the rectangle, use comma as the decimal point: ");
            double y = double.Parse(Console.ReadLine());

            double p = 0; // Perimeter

            double a; // Area

            RectangleHandler(x, y, ref p, out a);

            Console.WriteLine($"\nThe rectangle perimeter equals to {p} \nThe rectangle area equals to {a}\n\n");

            goto Start;

        }

        /// <summary>
        /// Calculates area and perimeter of a rectangle
        /// </summary>
        /// <param name="x">Length of rectangle side 1</param>
        /// <param name="y">Length of rectangle side 2</param>
        /// <param name="p">Perimeter of rectangle</param>
        /// <param name="a">Area of rectangle</param>
        static void RectangleHandler(double x, double y, ref double p, out double a)
        {
            p = (x + y) * 2;

            a = x * y;
        }
    }
}
