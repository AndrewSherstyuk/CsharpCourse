using System;

/// <summary>
/// Вывод элементов массива с помощью цикла foreach
/// </summary>
namespace _020_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива строковых элементов с именем stringArray 
            //размерностью в 5 элементов
            string[] stringArray = new string[5];

            //Присваиваем значение элементу массива stringArray по индексам с 0 по 4-й 
            stringArray[0] = "first element";
            stringArray[1] = "second element";
            stringArray[2] = "third element";
            stringArray[3] = "fourth element";
            stringArray[4] = "fifth element";

            //Вывод элементов массива с помощью цикла foreach

            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
