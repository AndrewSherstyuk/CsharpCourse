using System;

/// <summary>
/// Перечисления.
/// Получение информации о типе элементов перечисления.
/// </summary>
namespace _021_Enums
{
    class Program
    {
        static void Main()
        {
            EnumType enumType = EnumType.Six;

            //Type  - Информация о типе

            Type type = enumType.GetType();

            //Выводим информаци о типе
            Console.WriteLine(type.Name);

            //GetUnderlyingType - показывает тип, который используется для представления
            Type typeEnum = Enum.GetUnderlyingType(type);
            Console.WriteLine(typeEnum);

            //оператор typeof - содержит информацию о том типе
            Console.WriteLine(typeof(EnumType).FullName);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Перечисление EnumType
    /// </summary>
    enum EnumType: int
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
