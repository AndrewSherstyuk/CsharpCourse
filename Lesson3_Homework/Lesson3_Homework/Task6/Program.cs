using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("\nPlease enter the year you want to know if it's leap or not");

            int year = Convert.ToInt32(Console.ReadLine());

            bool divisibleBy4 = year % 4 == 0;
            bool divisibleBy100 = year % 100 == 0;
            bool divisibleBy400 = year % 400 == 0;

            if (divisibleBy4)
            {
                if (divisibleBy400)
                {
                    Console.WriteLine($"Year {year} is a leap year");
                }
                else if (divisibleBy100)
                {
                    Console.WriteLine($"Year {year} is NOT a leap year");
                }
                else
                {
                    Console.WriteLine($"Year {year} is a leap year");
                }
            }
            else
            {
                Console.WriteLine($"Year {year} is NOT a leap year");
            }

            goto Start;
        }
    }
}
