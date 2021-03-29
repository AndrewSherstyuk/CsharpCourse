using System;

/// <summary>
/// Перечисления
/// Параметр метода
/// </summary>
namespace _019_Enums
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine((int)EnumType.one);

            Method(EnumType.Zero);

            EnumType enumType = EnumType.Zero;
            Method(enumType);

            //Увиличиваем переменную enumType, с помощью инкремента
            Console.WriteLine(enumType++);
            //Переменна изменилась
            Console.WriteLine(enumType);
            Console.WriteLine((int)enumType);

            //Константа не изменилась
            Console.WriteLine((int)EnumType.Zero);

            //Задержка
            Console.ReadKey();
        }

        static void Method(EnumType enumType)
        {
            switch (enumType)
            {
                case EnumType.Zero:
                    Console.WriteLine("Число 0");
                    break;
                case EnumType.Five:
                    Console.WriteLine("Число 5");
                    break;
                case EnumType.Two:
                    Console.WriteLine("Число 2");
                    break;
                default: break;
            }
        }
    }

    /// <summary>
    /// Перечисление EnumType
    /// </summary>
    enum EnumType
    {
        Zero  = 0, 
        One,   // = 1
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        Six = Nine,
        Eight = 15, 
        Nine,
        Ten = 10
    }
}
