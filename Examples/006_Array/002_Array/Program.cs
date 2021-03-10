using System;

/// <summary>
/// Заполнение одномерного массива в цикле.
/// </summary>
namespace _002_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива целочисленных элементов с именем integerArray 
            //размерностью в 5 элементов
            int[] array = new int[5];

            //integerArray.Length - Свойство которое получает общее число элементов 
            //во всех измерениях массива System.Array.

            // Заполнение массива.
           /* for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = i;
            }*/

            //Аналогично через while
            int counter = 0;

            while (counter < 5)
            {
                array[counter] = counter;
                counter++;
            }

            // Вывод на экран значений элементов массива
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Задрежка.
            Console.ReadKey();
        }
    }
}
