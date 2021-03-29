using System;

/// <summary>
/// Перечесление
/// Сравнение 
/// </summary>
namespace _025_Enums
{
    class Program
    {
        static void Main()
        {
            EnumType enum1 = EnumType.Five;
            EnumType enum2 = EnumType.one;

            if (enum1 > enum2)
            {
                Console.WriteLine("enum1 > enum2");
            }
            else
            {
                Console.WriteLine("enum1 < enum2");
            }

            //или 

            if (EnumType.Five > EnumType.Four)
            {
                Console.WriteLine("EnumType.Five > EnumType.Four");
            }
            else
            {
                Console.WriteLine("EnumType.Five < EnumType.Four");
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
        one = 50,
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
