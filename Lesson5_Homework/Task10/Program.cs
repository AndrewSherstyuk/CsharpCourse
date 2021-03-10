using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("Please enter any number larger than 0: ");

            int number = int.Parse(Console.ReadLine());            

            Console.WriteLine($"The number of ranks is: {RankCounter(number)}\n\n");

            goto Start;
        }

        /*/// <summary>
        /// Counts number of ranks of any integer larger than 0 using 'while' loop
        /// </summary>
        /// <param name="x">The number to count number of ranks for</param>
        /// <param name="y">Number of ranks</param>
        static void RankCounter(int x, out int y)
        {
            y = 0;
            while (x > 0)
            {
                y++;
                x /= 10;                
            }
        } */

        /// <summary>
        /// Counts number of ranks of any integer larger than 0 using recursion
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Number of ranks</returns>
        static int RankCounter(int x)
        {
            // return (x <= 9) ? 1 : RankCounter(x / 10) + 1;
            if (x <= 9)
                return 1;
            else
            {
                return RankCounter(x / 10) + 1;
            }
        }
    }
}
