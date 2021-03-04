using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            Console.Write("\nPlease enter the rectangle length: ");

            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the rectangle height: ");

            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            for (int i = 0; i < h; i++ )
            {
                for (int j = 1; j <= l; j++)
                {
                    Console.Write("*   ");
                    if (j == l)
                        Console.WriteLine("\n");
                }                   
            }

            goto Start;
        }
    }
}
