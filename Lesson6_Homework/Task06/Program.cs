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
            Random r = new Random();

            Console.Write("Please specify how much elements you'd like to have in a new array: ");

            int l = int.Parse(Console.ReadLine());

            int[] myArray = new int[l];

            for (int i = 0; i <= l - 1; i++)
            {
                myArray[i] = r.Next(50);
            }

            for (int i = 0; i <= myArray.Length - 1; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            ArrayAnalizer(myArray);

            Console.ReadKey();
        }

        static void ArrayAnalizer(int[] a)
        {
            int sum = 0;

            string odds = string.Empty;

            double average;

            for (int i = 0; i <= a.Length - 1; i++)
            {
                sum += a[i];

                if (a[i] % 2 > 0)
                    odds += $"{a[i]} ";

                if (i < a.Length - 1)
                    continue;
                else
                {
                    Array.Sort(a);

                    average = (double)sum / a.Length;

                    Console.WriteLine($"MAX value is: {a[a.Length - 1]} \nMIN value is: {a[0]}");
                    Console.Write($"The sum of all the elements equals to: {sum}\n");
                    Console.Write($"The average of all the elements equals to: {Math.Round(average, 3)}\n");
                    Console.Write($"The odd numbers of the array are: {odds}\n");
                }
            }
        }
    }
}
