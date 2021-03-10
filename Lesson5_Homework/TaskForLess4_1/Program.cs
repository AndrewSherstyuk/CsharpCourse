using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLess4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("Please enter your number: ");

            int number = int.Parse(Console.ReadLine());

            //int sum;

            Summing(number, out int sum);

            Console.WriteLine($"The sum \'1 + 2 + 3 + ... + number\' is {sum}\n");

            goto Start;
        }

        static void Summing(int x, out int y)
        {
            y = 0;
            while (x >= 1)
            {                
                y += x;
                x--;
            }
        }
    }
}
