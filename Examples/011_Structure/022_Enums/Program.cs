using System;

/// <summary>
/// Перечисление
/// Формат
/// </summary>
namespace _022_Enums
{
    class Program
    {
        static void Main()
        {
            EnumType digit = EnumType.Ten;

            Console.WriteLine("Число {0}", digit.ToString());

            // Enum.Format() - Позволяет производить более точное форматирование за счет указания флага, 
            // а также получать имена элементов перечисления по их числовым значениям

            // Вывод в 10-тичном формате. Флаг "D" - dec (10-тичный формат)
            Console.WriteLine("Dec значение {0}", Enum.Format(typeof(EnumType), digit, "D"));

            // Вывод в строковом формате. Флаг "G" - str (Строковой формат)
            Console.WriteLine("Str значение {0}", Enum.Format(typeof(EnumType), 10, "G"));

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
