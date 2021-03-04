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
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            int a = 1;

            while (a <= 5)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("\n");

            int b = 1;

            do
            {
                Console.WriteLine(b);
                b++;
            }
            while (b <= 5);

            Console.ReadKey();

        }
    }
}