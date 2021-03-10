using System;

/// <summary>
/// Трехмерный массив
/// Массивы которые имеют три измерения (ранг равен 2) называют трехмерными.
/// Создание и заполнение трехмерного массива
/// </summary>
namespace _010_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание трехмерного массива целочисленных элементов с именем integerArray 
            //размерностью в [3,3,3] элементов.
            int[,,] integerArray = new int[3, 3, 3];

            integerArray[0, 0, 0] = 1;
            integerArray[0, 0, 1] = 2;
            integerArray[0, 0, 2] = 3;
            integerArray[0, 1, 0] = 4;
            integerArray[0, 1, 1] = 5;
            integerArray[0, 1, 2] = 6;
            integerArray[0, 2, 0] = 7;
            integerArray[0, 2, 1] = 8;
            integerArray[0, 2, 2] = 9;

            integerArray[1, 0, 0] = 1;
            integerArray[1, 0, 1] = 2;
            integerArray[1, 0, 2] = 3;
            integerArray[1, 1, 0] = 4;
            integerArray[1, 1, 1] = 5;
            integerArray[1, 1, 2] = 6;
            integerArray[1, 2, 0] = 7;
            integerArray[1, 2, 1] = 8;
            integerArray[1, 2, 2] = 9;

            integerArray[2, 0, 0] = 1;
            integerArray[2, 0, 1] = 2;
            integerArray[2, 0, 2] = 3;
            integerArray[2, 1, 0] = 4;
            integerArray[2, 1, 1] = 5;
            integerArray[2, 1, 2] = 6;
            integerArray[2, 2, 0] = 7;
            integerArray[2, 2, 1] = 8;
            integerArray[2, 2, 2] = 9;

            //Выводим на экран значений элементов массива integerArray 
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
