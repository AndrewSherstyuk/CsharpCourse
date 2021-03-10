using System;

/// <summary>
/// етырехмерный массив
/// </summary>
namespace _012_integerArray
{
    class Program
    {
        static void Main()
        {
            int[,,,] integerArray = new int[2, 2, 2, 2];

            integerArray[0, 0, 0, 0] = 0;
            integerArray[0, 0, 0, 1] = 1;
            integerArray[0, 0, 1, 0] = 2;
            integerArray[0, 0, 1, 1] = 3;

            integerArray[0, 1, 0, 0] = 4;
            integerArray[0, 1, 0, 1] = 5;
            integerArray[0, 1, 1, 0] = 6;
            integerArray[0, 1, 1, 1] = 7;

            integerArray[1, 0, 0, 0] = 8;
            integerArray[1, 0, 0, 1] = 9;
            integerArray[1, 0, 1, 0] = 10;
            integerArray[1, 0, 1, 1] = 11;

            integerArray[1, 1, 0, 0] = 12;
            integerArray[1, 1, 0, 1] = 13;
            integerArray[1, 1, 1, 0] = 14;
            integerArray[1, 1, 1, 1] = 15;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0} ", integerArray[i, j, k, l]);
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
