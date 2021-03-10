using System;

/// <summary>
/// Двухмерные массивы
/// Массивы которые имеют два измерения (ранг равен 2) называют двухмерными.
/// Создание и заполнение двухмерного массива
/// Двухмерные массивы представляет собой простую таблицу
/// </summary>
namespace _07_Array
{
    class Program
    {
        static void Main()
        {
            //Cоздание двухмерного массива целочисленных элементов с именем integerArray 
            //размерностью в [3,3] элементов, фактически таблица 3*3 (3 столбца, 3 строки)
            int[,] integerArray = new int[3, 3];

            //Заполнение элементов массива integerArray 
            integerArray[0, 0] = 1;
            integerArray[0, 1] = 2;
            integerArray[0, 2] = 3;

            integerArray[1, 0] = 4;
            integerArray[1, 1] = 5;
            integerArray[1, 2] = 6;

            integerArray[2, 0] = 7;
            integerArray[2, 1] = 8;
            integerArray[2, 2] = 9;

            // "\n" - переход на новою строку

            //Выводим на экран значений элементов массива integerArray 
            Console.Write(string.Format(@"{0} ", integerArray[0, 0]));
            Console.Write(string.Format(@"{0} ", integerArray[0, 1]));
            Console.Write(string.Format(@"{0} ", integerArray[0, 2]));

            Console.Write("\n");
            Console.Write(string.Format(@"{0} ", integerArray[1, 0]));
            Console.Write(string.Format(@"{0} ", integerArray[1, 1]));
            Console.Write(string.Format(@"{0} ", integerArray[1, 2]));

            Console.Write("\n");
            Console.Write(string.Format(@"{0} ", integerArray[2, 0]));
            Console.Write(string.Format(@"{0} ", integerArray[2, 1]));
            Console.Write(string.Format(@"{0} ", integerArray[2, 2]));
            
            // Задрежка.
            Console.ReadKey();
        }
    }
}
