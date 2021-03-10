using System;

/// <summary>
/// Четырехмерный массив
/// </summary>
namespace _013_Array
{
    class Program
    {
        static void Main()
        {
            int[,,,] integerArray =
            {
              {
                { { 0, 1 }, {2, 3 } },
                { { 4, 5 }, {6, 7 } }
              },
              {
                { { 8, 9 },   {10, 11 } },
                { { 12, 13 }, {14, 15 } }
              }
            };


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write(integerArray[i, j, k, l] + " ");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
