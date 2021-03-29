using System;

/// <summary>
///  Можно использовать псевдоним любого целого 
///  типа данных:byte, sbyte, short, ushort, int,uint, long, ulong.
///  Но нельзя использовать любой системный целый тип данных: 
///  Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64
/// </summary>
namespace _018_Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine((int)EnumTypeInt.Zero);
            Console.WriteLine((int)EnumTypeInt.One);
            Console.WriteLine((int)EnumTypeInt.Two);
            Console.WriteLine((int)EnumTypeInt.Three);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Перечисление EnumTypeInt
    /// </summary>
    enum EnumTypeInt : int 
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    /// <summary>
    /// Перечисление EnumTypeIntInt32 
    /// </summary>
    enum EnumTypeIntInt32 : Int32
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }
}
