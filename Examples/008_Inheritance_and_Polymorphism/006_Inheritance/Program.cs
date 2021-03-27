using System;

/// <summary>
/// UpCast && DownCast
/// замещение методов
/// </summary>
namespace _006_Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            Console.WriteLine(derivedClass.MyProperty);

            Console.WriteLine(new string('*', 10));

            // UpCast
            BaseClass UpCastbaseClass = (BaseClass)derivedClass;
            UpCastbaseClass.Method();
            Console.WriteLine(UpCastbaseClass.MyProperty);

            Console.WriteLine(new string('*', 10));

            // DownCast
            DerivedClass downCastDerivedClass = (DerivedClass)UpCastbaseClass;
            downCastDerivedClass.Method();
            Console.WriteLine(downCastDerivedClass.MyProperty);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// </summary>
    class DerivedClass : BaseClass
    {
        public new int MyProperty { get; set; } = 20; 

        // Замещение метода базового класса.
        public new void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        public int MyProperty { get; set; } = 10;
        public void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }
}
