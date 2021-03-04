using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Divisible by 3 but not by 5
            
            for (int i = 20; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 > 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            // Divisible by 5 but not by 3

            int a = 20;

            while (a <= 50)
            {
                if (a % 3 > 0 && a % 5 == 0)
                    Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("\n");

            // Divisible by both 3 and 5
            
            int b = 20;

            do
            {
                if (b % 3 == 0 && b % 5 == 0)
                    Console.WriteLine(b);
                b++;
            }
            while (b <= 50);

            Console.ReadKey();
        }
    }
}
