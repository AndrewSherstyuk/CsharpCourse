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
            
            Console.Write("\nPlease enter an integer value for A: ");

            int a = int.Parse(Console.ReadLine());

            int c = a;

            Console.Write("Please enter an integer value for B: ");

            int b = int.Parse(Console.ReadLine());

            int d = b;

            if (a >= b)
            {
                Console.WriteLine("To make the programm work correctly, B should be larger than A. Please try again\n\n");
            }
            else
            {
                int temp = 0;

                int counter = 0;

                while (a < (b - 1))
                {       
                    a++;

                    temp += a;

                    if (counter == 0)
                        Console.Write("\nThese are all the odd numbers between A and B: ");

                    counter++;
                    
                    if (a % 2 > 0)
                    {
                        Console.Write($"{a} ");
                    }

                    if (a < (b - 1))
                        continue;

                    Console.WriteLine($"\nThe sum of all the numbers between A and B is: {temp}");                    
                }
            }

            goto Start;
        }
    }
}
