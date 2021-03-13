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
            Random rnd = new Random();

            Console.Write("Please enter the length of the initial array: ");

            int l = int.Parse(Console.ReadLine());
            
            int[] initialArray = new int[l];

            for (int x = 0; x <= l - 1; x++)
            {
                initialArray[x] = rnd.Next(50);
                Console.Write($"{initialArray[x]} ");
            }

            Console.WriteLine("\nPlease enter the index to start copying from: ");

            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter how many elements you'd like to copy: ");

            int h = int.Parse(Console.ReadLine());

            int[] newArray = new int[h];

            Array.Copy(initialArray, i, newArray, 0, h);

            for (int x = 0; x <= h - 1; x++)
            {
                if (x == 0)
                {
                    Console.Write("\nYour new array looks as follows: ");
                }

                Console.Write($"{newArray[x]} ");
            }

            Console.ReadLine();
        }
    }
}
