using System;

/// <summary>
/// Перечисления
/// Значение по умолчанию для перечислений
/// </summary>
namespace _020_Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine((int)EnumType.One);

            EnumType twodewceascxsd = (EnumType)2;

            // Переменной five типа EnumType может быть назначено любое значение, 
            // входящее в диапазон базового типа
            EnumType ten = (EnumType)10;

            Console.WriteLine(twodewceascxsd);
            Console.WriteLine(ten);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Перечисление EnumType
    /// </summary>
    enum EnumType: byte
    {
        Zero = 0,
        One = 1,
        Two1 = 2,
        Two = 2,
        Three = 3,
        ten = 10
    }
}
