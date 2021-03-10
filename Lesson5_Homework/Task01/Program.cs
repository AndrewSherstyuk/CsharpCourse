using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("Please enter an integer value for A: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter an integer value for B: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter an integer value for C: ");

            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe average of A, B and C is {Math.Round(AverageNumber(a, b, c), 3)}");
            Console.WriteLine("\n");

            goto Start;
        }

        /// <summary>
        /// Calculates average of 3 intergers
        /// </summary>
        /// <param name="x">Integer</param>
        /// <param name="y">Integer</param>
        /// <param name="z">Integer</param>
        /// <returns>returns Average of numbers x, y and z</returns>
        static double AverageNumber (int x, int y, int z)
        {
            double average = ((double)(x + y + z)) / 3;
            return average;
        }
    }
}
