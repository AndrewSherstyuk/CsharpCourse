using System;

/// <summary>
/// Заполнение одномерного массива в блоке инициализатора,
/// без указания размерности массива
/// </summary>
namespace _004_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива целочисленных элементов с именем integerArray 
            //без указания размерности массива и заполнение его значениями в блоке инициализатора
            int[] integerArray = new int[] { 1, 2, 300, 4485, 5 };

            // Вывод на экран значений элементов массива
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            //Оттеняем создание строкового массива
            Console.WriteLine(new string('*', 30));

            //Cоздание массива строковых элементов с именем stringArray 
            //без указания размерности массива и заполнение его значениями в блоке инициализатора
            string[] stringArray = new string[]
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
