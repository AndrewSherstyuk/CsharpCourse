using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int[,] myArray = new int[10, 10];
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    myArray[i, j] = rnd.Next(1, 50);

                    Console.Write("{0}\t", myArray[i, j]);
                }
                Console.Write("\n\n");
            }

            int rowSum;

            long colProd;

            int[] diag = new int[10];

            int l = 0;

            for (int i = 0; i < 10; i++)
            {
                rowSum = 0;                
                
                for (int j = 0; j < 10; j++)
                {
                    rowSum += myArray[i, j];

                    if (i == j)
                    {
                        diag[l] = myArray[i, j];

                        l++;
                    }
                }

                Console.Write($"\n\nSum of row {i + 1} equals to {rowSum}");
            }

            for (int j = 0; j < 10; j++)
            {
                colProd = 1;

                for (int i = 0; i < 10; i++)
                {
                    colProd *= myArray[i, j];
                }

                Console.Write($"\n\nProduct of column {j + 1} equals to:  {colProd}");
            }

            Array.Sort(diag);
            
            Console.Write($"\n\nThe largest element within main diagonal equals to: {diag[diag.Length - 1]}");

            Console.ReadKey();
        }
    }
}
