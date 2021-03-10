using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("Please enter an integer value for operand1: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter an integer value for operand2: ");

            int b = Convert.ToInt32(Console.ReadLine());

        SelectOperation1:

            Console.Write("Please select operation. \'*\', \'/\', \'+\' or \'-\': ");

        SelectOperation2:

            char o = Convert.ToChar(Console.ReadLine());

            switch (o)
            {
                case '*':
                    {
                        Console.WriteLine($"Result equals to {Mul(a, b)}");
                        break;
                    }
                case '/':
                    {
                        if (b != 0)
                        {
                            Console.WriteLine($"Result equals to {Div(a, b)}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Operand2 equals to zero: operation impossible");
                            goto SelectOperation1;
                        }
                    }
                case '+':
                    {
                        Console.WriteLine($"Result equals to {Sum(a, b)}");
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine($"Result equals to {Dif(a, b)}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please select a valid operation sign: ");
                        goto SelectOperation2;
                    }
            }

            goto Start;
        }

        /// <summary>
        /// Multiplies x by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>result of multiplication</returns>
        static int Mul(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Divides x by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>double quotient</returns>
        static double Div(int x, int y)
        {
            if (y != 0)
            {
                double z = Math.Round((double)x / (double)y, 3);
                return z;
            }
            else
            {
                return 000;
            }
        }

        /// <summary>
        /// Adds x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>int sum</returns>
        static int Sum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Substracts y from x
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>int difference</returns>
        static int Dif(int x, int y)
        {
            return x - y;
        }
    }
}
