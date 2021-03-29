using System;

/// <summary>
/// Перечисление
/// Поиск элемента перечисления по имени константы.
/// </summary>
namespace _023_Enums
{
    class Program
    {
        static void Main()
        {
            // Находим элемент перечисления по имени константы.
            object element = Enum.Parse(typeof(EnumType), "Three");
            //Приводим element типа object к типу перечесления EnumType
            EnumType number = (EnumType)element;

            Console.WriteLine("Значение константы {0}: {1}", number, (byte)number);

            string @string = "one";

            //IsDefined - определить, является ли символьная строка элементом перечисления
            bool elementsDefined = Enum.IsDefined(typeof(EnumType), @string);

            if (elementsDefined)
            {
                Console.WriteLine(string.Format(@"Перечисление содержит {0}", @string));
            }
            else
            {
                Console.WriteLine(string.Format(@"Перечисление не содержит {0}", @string));
            }

            //Задержка
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
