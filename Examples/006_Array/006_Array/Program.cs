using System;
using System.Collections.Generic;

/// <summary>
/// Заполнение одномерного массива значениями по умолчанию.
/// </summary>
namespace _006_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива целочисленных элементов с именем integerArray 
            //размерностью в 5 элементов
            int[] integerArray = new int[5];

            //Вывод на экран значений элементов массива
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            //Оттеняем создание строкового массива
            Console.WriteLine(new string('*', 30));

            //Cоздание массива строковых элементов с именем stringArray 
            //размерностью в 5 элементов
            string[] stringArray = new string[5];

            //Вывод на экран значений элементов массива
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Задрежка.
            Console.ReadKey();
        }
    }
}
