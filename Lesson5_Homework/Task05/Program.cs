using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
           Start:
            
            Console.Write("Please enter the money amount you want to exchange, use comma as the decimal point: ");

            double amount = double.Parse(Console.ReadLine());

            Console.Write("Please enter the exchange rate, use comma as the decimal point: ");

            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Converter(amount, rate)}");

            goto Start;
        }

        /// <summary>
        /// Converts currency via multiplying money amount by currency rate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double Converter(double x, double y)
        {
            return x * y;
        }
    }
}
