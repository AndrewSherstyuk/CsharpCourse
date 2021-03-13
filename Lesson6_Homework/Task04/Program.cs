using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("Please enter your word: ");

            string myWord = Console.ReadLine();

            Console.WriteLine($"Here's your reversed word: {Reverse(myWord)}\n\n");

            goto Start;
        }

        /// <summary>
        /// Changes the order of chars in a word to reversed
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        static string Reverse(string myString)
        {
            char[] A = myString.ToCharArray();

            char[] B = new char[A.Length];

            int m = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                B[m] = A[i];
                m++;
            }

            string reverse = new string(B);

            return reverse;
        }
    }
}
