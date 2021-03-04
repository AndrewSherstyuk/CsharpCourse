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
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{i} * 3 = {i * 3}");
            }

            int a = 1;

            Console.WriteLine("\n");

            while (a <= 9)
            {
                Console.WriteLine($"{a} * 3 = {a * 3}");
                a++;
            }

            Console.WriteLine("\n");

            int b = 1;

            do
            {
                Console.WriteLine(String.Concat(b.ToString(), " * 3 = ", (b * 3).ToString()));
                b++;
            }
            while (b <= 9);

            Console.ReadKey();
        }
    }
}
