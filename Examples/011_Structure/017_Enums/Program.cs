using System;

/// <summary>
/// Перечисления
/// </summary>
namespace _017_Enums
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine((long)EnumType.One); 

            Enum one = EnumType.One;
            Console.WriteLine(one);

            EnumType enumType = EnumType.Zero;
            Enum zero = enumType;
            Console.WriteLine(zero);

            Console.WriteLine(new string('-', 10));

 

            for (EnumType number = EnumType.Zero; number <= EnumType.Three; number++)
            {
                Console.WriteLine((byte)number + " - " +number);
            }

            //Задержка
            Console.ReadKey();

            MyClass myClass = new MyClass();
            myClass.MyProperty = EnumType.Two;
        }
    }

    class MyClass
    {
        public EnumType MyProperty { get; set; }
    }

    /// <summary>
    /// Перечесление с имнем EnumType
    /// </summary>
    enum EnumType : long
    {
        Zero = 0,
        One = 100,
        Two = 2,
        Three = 3
    }
}
