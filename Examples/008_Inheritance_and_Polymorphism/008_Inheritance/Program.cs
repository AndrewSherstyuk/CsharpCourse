using System;

/// <summary>
/// Ключевое слово base 
/// </summary>
namespace _008_Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// </summary>
    class DerivedClass : BaseClass
    {
        /// <summary>
        /// Метод из производного класса.
        /// </summary>
        public override void Method()
        {
            // Вызов метода базового класса.
            base.Method();

            Console.WriteLine("Method from DerivedClass");
        }
    }
    
    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        /// <summary>
        /// Метод из базового класса
        /// </summary>
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }
}
