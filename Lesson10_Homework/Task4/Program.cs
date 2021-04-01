using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a number of elements in your new array");
            int l = int.Parse(Console.ReadLine());
            
            int[] a = ArrayHandler.ArrayCreator(l);

            Console.WriteLine($"\nHERE'S YOUR NEW ARRAY OF {l} ELEMENTS \n{new string('=', 40)}");
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();

            ArrayHandler.ArraySorter(ref a);

            Console.WriteLine($"\nHERE'S YOUR NEW ARRAY SORTED ASCENDING \n{new string('=', 40)}");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }

            Console.ReadKey();
        }
    }

    public static class ArrayHandler
    {
        public static int[] ArrayCreator(int i)
        {
            Random rnd = new Random();
            
            int[] newArray = new int[i];

            for (int j = 0; j < i; j++)
            {
                newArray[j] = rnd.Next(1, 50);
            }
            return newArray;
        }

        public static void ArraySorter(ref int[] a)
        {
            //Array.Sort(a);
            
            int temp;

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }

    

}
