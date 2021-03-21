using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] myArray = createArray(10);

            int totalSum = 0;

            int evenSum = 0;

            double average = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                totalSum += myArray[i];

                if (myArray[i] % 2 == 0)
                {
                    evenSum += myArray[i];
                }

                if (i == myArray.Length - 1)
                {
                    average = (double)totalSum / (double)myArray.Length;
                }                
            }

            Console.WriteLine("Sum of all the elements is {0} \nSum of all the even elements is {1} " +
                    "\nAverage of all the elements is {2}", totalSum, evenSum, average);

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("The elements that are greater than average are: ");
                }

                if ((double)myArray[i] > average)
                {
                    Console.Write($"{myArray[i]}  ");
                }
            }

            Console.ReadKey();
        }

        static int[] createArray(int x)
        {
            Random rnd = new Random();

            int[] newArray = new int[x];

            for (int i = 0; i < x; i++)
            {
                newArray[i] = rnd.Next(1, 20);
            }

            return newArray;
        }
    }
}
