using System;

/// <summary>
/// Двухмерные массивы
/// Заполнение массива и вывод значений элементов массива в цикле
/// </summary>
namespace _008_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание двухмерного массива целочисленных элементов с именем integerArray 
            //размерностью в [3,3] элементов, фактически таблица 3*3 (3 столбца, 3 строки)
            int[,] integerArray = new int[3, 3];

            //Общее число элементов во всех измерениях массива System.Array;
            //для 2-х мерного массива 3*3 число элементов во всех измерениях = 9
            Console.WriteLine(@"Общее число элементов 2-х мерного массива = {0}", integerArray.Length);

            //Console.WriteLine(integerArray.Length);

            // Заполнение массива
            // Заполнение строк
            for (int i = 0; i < 3; i++)
            {
                //Заполнение столбцов
                for (int j = 0; j < 3; j++)
                {
                    integerArray[i, j] = i * j + 1;
                }
            }

            //Выводим на экран значений элементов массива integerArray 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", integerArray[i, j]);
                }
                Console.Write("\n");
            }

            // Задрежка.
            Console.ReadKey();
        }
    }
}
