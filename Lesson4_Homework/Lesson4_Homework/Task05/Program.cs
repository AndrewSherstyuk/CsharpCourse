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
            Console.WriteLine("Please enter any integer");

            int a = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            int b = 0;

            Console.WriteLine("\n");

            while (i < a)
            {
                i++;

                b += i;

                Console.WriteLine($"{i} => {b}");
            }

            Console.ReadKey();
        }
    }
}
