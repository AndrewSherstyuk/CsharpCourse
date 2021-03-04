using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("\n\nPlease specify how many numbers of a Fibonacci sequence you want to have: ");

            int number = int.Parse(Console.ReadLine());

            int counter = 1;

            int a = 0;

            int b = 1;

            int temp = 0;

            while (counter <= number)
            {
                if (counter == 1)
                    Console.Write("\nHere you are: ");

                Console.Write($"{a} "); 
                
                temp = a + b;
                a = b;
                b = temp;

                counter++;
            }

            goto Start;
        }
    }
}
