using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("Please enter any number larger than 0: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(MethodToSum(number));

            goto Start;
        }

        /// <summary>
        /// Calculates sum of all numbers int x consists of
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int MethodToSum(int x)
        {             
            if (x < 1)
                return 0;
            if (x < 10)
                return x;
            else
                return (x % 10) + MethodToSum((x - x % 10) / 10); 
        }
    }
}
