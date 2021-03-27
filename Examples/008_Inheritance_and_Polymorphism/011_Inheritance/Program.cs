using System;

/// <summary>
/// Cast с использованием оператора as.
/// </summary>
namespace _011_Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            // UpCast
            BaseClass upCastBaseClass = derivedClass as BaseClass;
            upCastBaseClass.Method();

            // DownCast
            DerivedClass downCastDerivedClass = upCastBaseClass as DerivedClass;
            downCastDerivedClass.Method();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// </summary>
    class DerivedClass : BaseClass
    {
        // Переопределение метода базового класса.
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }
}
