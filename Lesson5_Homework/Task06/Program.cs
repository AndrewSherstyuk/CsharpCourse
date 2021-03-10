using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.WriteLine("Please enter an integer value for A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an integer value for B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an integer value for C");
            int c = int.Parse(Console.ReadLine());           

            Multiplier(ref a, ref b, c, out int z);

            Console.WriteLine($"After multiplication by 10, A equals to {a}, B equals to {b}, C equals to {z}\n\n");

            goto Start;
        }

        /// <summary>
        /// Multiplies input parameters by 10
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="z1"></param>
        static void Multiplier(ref int x, ref int y, int z, out int z1)
        {
            x *= 10;

            y *= 10;

            z1 = z * 10;
        }

    }
}
