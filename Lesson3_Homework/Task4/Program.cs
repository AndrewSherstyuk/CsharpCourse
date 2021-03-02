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
            Console.WriteLine("Please enter any number. The only condition: it must be integer");

            int a = Convert.ToInt32(Console.ReadLine());

            int remainderDivBy2 = a % 2;

            int remainderDivBy3 = a % 3;

            int remainderDivBy6 = a % 6;

            if (remainderDivBy2 > 0)
            {
                Console.WriteLine("The number you entered is odd");
            }
            else
            {
                Console.WriteLine("The number you entered is even");
            }

            if (remainderDivBy3 > 0)
            {
                Console.WriteLine("The number you entered is divided by 3 with a remainder");
            } 
            else
            {
                Console.WriteLine("The number you entered is divided by 3 with no remainder");
            }

            if (remainderDivBy6 > 0)
            {
                Console.WriteLine("The number you entered is divided by 6 with a remainder");
            }
            else
            {
                Console.WriteLine("The number you entered is divided by 6 with no remainder");
            }

            Console.ReadKey();
        }
    }
}
