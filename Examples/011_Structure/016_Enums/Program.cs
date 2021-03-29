using System;

/// <summary>
/// Перечисления
/// Перечисление - это набор именованных констант, 
/// которые хранят числовые значения.
/// Перечисление определяет именованные константы, 
/// каждой из которых соответствует числовое значение.
/// Все перечисления в C# происходят от единого 
/// Базового класса System.Enum
/// </summary>
namespace _016_Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(EnumType.One);

            Console.WriteLine((byte)EnumType.One);

            EnumType enumType = EnumType.One;
           
            Console.WriteLine(enumType);
            Console.WriteLine((byte)enumType);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Перечесление с имнем EnumType
    /// Можно использовать любой целый тип данных
    /// C# (byte, sbyte, short, ushort, int, uint, long, ulong)
    /// </summary>
    public enum EnumType : byte
    {
        Zero ,
        One ,
        Two ,
        Three 
    }
}
