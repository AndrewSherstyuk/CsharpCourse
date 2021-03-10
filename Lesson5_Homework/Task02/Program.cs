using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Start: 
            
            Console.Write("Please specify a value for A: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Please specify a value for B: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("\n");

            if (a == b)
            {
                WriteInRed($"{a} equals to {b}, please specify different numbers in order to get result of comparison\n");
            }
            else
            {
                WriteInGreen($"{Comparison(a, b)} is less\n");
            }

            goto Start;
        }

        /// <summary>
        /// This method returns the least of two given numbers
        /// </summary>
        /// <param name="x">integer</param>
        /// <param name="y">integer</param>
        /// <returns></returns>
        static int Comparison(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else if (x < y)
            {
                return x;
            }
            else
            {
                return 000;
            }
        }

        /// <summary>
        /// This method accepts a string and writes it in green color in console
        /// </summary>
        /// <param name="myString"></param>
        static void WriteInGreen(string myString)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(myString);
            Console.ResetColor();
        }

        /// <summary>
        /// The method accepts a string and writes it in red color in console
        /// </summary>
        /// <param name="myString"></param>
        static void WriteInRed(string myString)
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine(myString);
            Console.ResetColor(); 
        }
    }
}
