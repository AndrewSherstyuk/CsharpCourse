using System;

/// <summary>
/// Массив представляет набор однотипных данных.Объявление массива 
/// похоже на объявление переменной за тем исключением, 
/// что после указания типа ставятся квадратные скобки:
/// тип_переменной[] название_массива;
/// </summary>
namespace _001_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива целочисленных элементов с именем integerArray 
            //размерностью в 5 элементов
            int[] integerArray = new int[5];

            //Элементу массива integerArray по индексу 0 присваиваем значение 10
            integerArray[0] = 10;
            //Элементу массива integerArray по индексу 1 присваиваем значение 20
            integerArray[1] = 20;
            //Элементу массива integerArray по индексу 2 присваиваем значение 30
            integerArray[2] = 30;
            //Элементу массива integerArray по индексу 3 присваиваем значение 40
            integerArray[3] = 40;
            //Элементу массива integerArray по индексу 4 присваиваем значение 50
            integerArray[4] = 50;

            //Выводим на экран значение элемента массива integerArray по индексу 0
            Console.WriteLine(integerArray[0]);
            //Выводим на экран значение элемента массива integerArray по индексу 1
            Console.WriteLine(integerArray[1]);
            //Выводим на экран значение элемента массива integerArray по индексу 2
            Console.WriteLine(integerArray[2]);
            //Выводим на экран значение элемента массива integerArray по индексу 3
            Console.WriteLine(integerArray[3]);
            //Выводим на экран значение элемента массива integerArray по индексу 4
            Console.WriteLine(integerArray[4]);

            //Оттеняем создание строкового массива
            Console.WriteLine(new string('*', 30));

            //Cоздание массива строковых элементов с именем stringArray 
            //размерностью в 5 элементов
            string[] stringArray = new string[5];

            //Присваиваем значение элементу массива stringArray по индексам с 0 по 4-й 
            stringArray[0] = "first element";
            stringArray[1] = "second element";
            stringArray[2] = "third element";
            stringArray[3] = "fourth element";
            stringArray[4] = "fifth element";

            //Выводим на экран значение элементов массива stringArray  по индексам с 0 по 4-й 
            Console.WriteLine(stringArray[0]);
            Console.WriteLine(stringArray[1]);
            Console.WriteLine(stringArray[2]);
            Console.WriteLine(stringArray[3]);
            Console.WriteLine(stringArray[4]);

            // Задрежка.
            Console.ReadKey();
        }
    }
}
