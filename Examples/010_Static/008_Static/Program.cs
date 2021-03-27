using System;

/// <summary>
/// Статические методы в абстрактных классах
/// </summary>
namespace _008_Static
{
    class Program
    {
        static void Main()
        {
            BaseClass.Method();
            DerivedClass.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый абстрактный класс BaseClass
    /// </summary>
    abstract class BaseClass
    {
        //Статические члены не могут быть виртуальными, 
        //переопределенными и абстрактными.
        //public static virtual void StaticMethod()
        //{
        //    Console.WriteLine("static method from base class");
        //}

        /// <summary>
        /// Статический метод из базового абстрактного класса
        /// </summary>
        public static void Method()
        {
            Console.WriteLine("Static method from base class");
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового 
    /// абстрактного класса BaseClass
    /// </summary>
    class DerivedClass : BaseClass
    {
        //Статические члены не могут быть виртуальными, 
        //переопределенными и абстрактными.
        //public static override void StaticMethod()
        //{
        //    Console.WriteLine("static method from base class");
        //}

        /// <summary>
        /// Статические члены поддерживают замещение. (new)
         /// </summary>
        public static /*new*/ void Method()
        {
            Console.WriteLine("Static method from derived class");
        }
    }
}
