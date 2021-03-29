using System;

/// <summary>
///  Перечесление
///  Получение информации о количестве элементов перечисления. 
///  Получение всех элементов перечисления и их значений
/// </summary>
namespace _024_Enums
{
    class Program
    {
        static void Main()
        {
            //GetValues - получить массив перечеслений
            Array array = Enum.GetValues(typeof(EnumType));

            Console.WriteLine(string.Format(@"Перечесление содержет {0} елементов", array.Length));

            //выводим елементы перечеслений
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(string.Format(@"{0} - {1}", i, array.GetValue(i)));
            }

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Перечисление EnumType
    /// </summary>
    enum EnumType : int
    {
        Zero,  // = 0 
        One,   // = 1
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        Six = Nine,
        Eight = 8,
        Nine,
        Ten = 10
    }
}
