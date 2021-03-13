using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForL5_2
{
    class Program
    {
        static void Main(string[] args)
        {
         Start:    
            
            Console.Write("Please enter your A number: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter your B number: ");

            int b = int.Parse(Console.ReadLine());

            myMethod(a, b);

            Console.ReadKey();

            goto Start;
        }

        static int myMethod(int a, int b)
        {
            if (a <= b)
            {
                if (a == b)
                {
                    Console.WriteLine(b);
                    return b;
                }
                else
                {
                    Console.WriteLine(a);
                    return myMethod(++a, b);
                }
            }
            else
            {
                Console.WriteLine(a);
                return myMethod(--a, b);
            }
        }
    }
}
