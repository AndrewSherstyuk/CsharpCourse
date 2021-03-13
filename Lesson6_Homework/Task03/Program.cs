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
            string[] A = new string[4];

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Please enter element {i} of the array");
                A[i] = Console.ReadLine();
                Console.WriteLine($"Element {i} is successfully saved\n");
            }

            string[] B = new string[4];

            int l = A.Length;

            for (int i = 0; i <= 3; i++)
            {                
                B[i] = A[l - 1];

                if (i == 0)
                {
                    Console.Write("The elements of array B are: ");
                }

                Console.Write($"{B[i]} ");
                l--;
            }

            Console.ReadKey();
        }
    }
}
