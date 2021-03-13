using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.Write("Please enter the length of your array: ");            

            int l = int.Parse(Console.ReadLine());

            int[] initialArray = new int[l];

            for (int i = 0; i < l; i++)
            {
                if (i == 0)
                {
                    Console.Write("Your new array have the following elements: ");
                }

                initialArray[i] = rnd.Next(1, 50);

                Console.Write($"{initialArray[i]} ");
            }            

            Console.Write("\nPlease enter the value for 0-index element of the new array: ");

            int zeroIndexValue = int.Parse(Console.ReadLine());

            int[] newArray = ArrayChanger(initialArray, zeroIndexValue);

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("The new array has the following elements: ");
                }
                Console.Write($"{newArray[i]} ");
            }

            Console.ReadKey();
        }

        static int[] ArrayChanger(int[] array, int a)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[0] = a;

            array.CopyTo(newArray, 1);

            return newArray;
        }

    }
}
