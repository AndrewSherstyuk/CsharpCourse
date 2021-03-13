using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] income = new int[12];

            for (int i = 0; i <= (income.Length - 1); i++)
            {
                Console.WriteLine($"Please enter income amount for month {i + 1}");

                income[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter month 1 of the range you need statistics for");

            int m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter month 2 of the range you need statistics for");

            int m2 = int.Parse(Console.ReadLine());

            RangePicker(income, m1, m2, out int[] range); // Saving the values of income from specified range into a new array

            Array.Sort(range); // Soring the new array in order to have min value at the beginning and max value at the end

            int maxValue = range[range.Length - 1];

            int minValue = range[0];

            // Checking what months of the range have max and min value
            for (int i = 0; i <= income.Length - 1; i++)
            {
                if (i >= m1 - 1 && i <= m2 -1)
                {
                    if (income[i] == maxValue)
                        Console.WriteLine($"The MAX income {maxValue} of the range was in month {i + 1}");

                    if (income[i] == minValue)
                        Console.WriteLine($"The MIN income {minValue} of the range was in month {i + 1}");
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Copies all elememets of input array into a new array
        /// </summary>
        /// <param name="A"></param>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="range"></param>
        /// <returns>New range</returns>
        static int[] RangePicker(int[] A, int m1, int m2, out int[] range)
        {
            range = new int[m2 - (m1 - 1)];

            int u = 0;

            for (int i = (m1 - 1); i <= (m2 - 1); i++)
            {
                range[u] = A[i];
                u++;
            }

            return range;
        }
    }
}
