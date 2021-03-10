using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("Please enter your number: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(TaskMethod(number));

            goto Start;
        }

        /// <summary>
        /// Recursively adds all numbers between 1 and x
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Sum of numbers '1 + 2 + ... + 3'</returns>
        static int TaskMethod(int x)
        {
            if (x < 1)
                return 0;
            else if (x == 1)
                return 1;
            else
            {
                return x + TaskMethod(x - 1);
            }
        }
    }
}
