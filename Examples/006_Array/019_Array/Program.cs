using System;

/// <summary>
/// Random - класс- 
/// представляет генератор псевдослучайных чисел, то есть устройство, которое выдает
/// последовательность чисел, отвечающую определенным статистическим критериям случайности.
/// </summary>
namespace _019_Array
{
    class Program
    {
        static void Main()
        {
            //Создание класса Random
            Random random = new Random();

            //Создание массива целочисленных элементов
            int[] integerArray = new int[5];

            //Заполнение элементов случайными числами 
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = random.Next(1, 100);
            }

            //Вывод элементов массива
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
