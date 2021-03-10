using System;
using System.Linq;

/// <summary>
/// Основные свойства и методы класса Array:
/// Подключить using System.Linq; !!!
/// </summary>
namespace _021_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание массива строковых элементов с именем stringArray 
            //размерностью в 5 элементов
            string[] stringArray = new string[5];
            string[] stringArrayCopy = new string[5];

            //Присваиваем значение элементу массива stringArray по индексам с 0 по 4-й 
            stringArray[0] = "first element";
            stringArray[1] = "second element";
            stringArray[2] = "third element";
            stringArray[3] = "fourth element";
            stringArray[4] = "fifth element";

            //Свойство Length возвращает длину массива
            Console.WriteLine(stringArray.Length);

            Console.WriteLine(new string('-', 30));
            
            //Свойство Rank возвращает ранг (число измерений)
            Console.WriteLine(stringArray.Rank);

            Console.WriteLine(new string('-', 30));
            
            //Метод Copy() копирует часть одного массива в другой массив
            stringArray.CopyTo(stringArrayCopy, 0);

            foreach (string arrayElement in stringArrayCopy)
            {
                Console.WriteLine(arrayElement);
            }

            Console.WriteLine(new string('-', 30));
           
            //Располагает элементы массива в обратном порядке
            foreach (string arrayElement in stringArray.Reverse())
            {
                Console.WriteLine(arrayElement);
            }

            //Задержка.
            Console.ReadKey();
        }
    }
}
