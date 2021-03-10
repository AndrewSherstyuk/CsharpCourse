using System;

/// <summary>
/// Двухмерные массивы
/// Заполнение двухмерного массивава блоке инициализатора
/// </summary>
namespace _009_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание двухмерного массива целочисленных элементов с именем integerArray
            //размерностью в [3,3] элементов, компилятор определяет размер массива на 
            //основании выражения инициализации.
            int[,] integerArray = 
                            {
                             { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 }
                           };

            
            //Информация о созданном массиве
            Console.WriteLine(integerArray);
            Console.WriteLine(integerArray.Length);

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
