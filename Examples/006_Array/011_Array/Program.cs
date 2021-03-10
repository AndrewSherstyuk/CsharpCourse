using System;

/// <summary>
/// Трехмерный массив
/// Заполнение трехмерного массив массива в блоке инициализатора
/// </summary>
namespace _011_Array
{
    class Program
    {
        static void Main()
        {
            int[,,] integerArray =
            {
               { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
               { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
               { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };

            Console.WriteLine(integerArray);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", integerArray[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }

            // Задрежка.
            Console.ReadKey();
        }
    }
}
