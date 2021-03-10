using System;

/// <summary>
/// Заполнение одномерного массива в блоке инициализатора
/// </summary>
namespace _003_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива целочисленных элементов с именем integerArray 
            //размерностью в 5 элементов и заполнение его значениями в блоке инициализатора
            int[] integerArray = new int[5] { 1, 2, 3, 4, 5 };

            // Вывод на экран значений элементов массива
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            //Оттеняем создание строкового массива
            Console.WriteLine(new string('*', 30));

            //Cоздание массива строковых элементов с именем stringArray 
            //размерностью в 5 элементов
            string[] stringArray = new string[5] 
                { 
                    "first element",
                    "second element",
                    "third element",
                    "fourth element",
                    "fifth element",
                };

            // Вывод на экран значений элементов массива
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Задрежка.
            Console.ReadKey();
        }
    }
}
