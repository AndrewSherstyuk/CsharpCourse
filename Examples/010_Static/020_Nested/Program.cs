using System;

/// <summary>
/// Вложенные классы.
/// Наследование - внешний класс.
/// </summary>
namespace _020_Nested
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.MethodFromBase();

            Console.WriteLine(new string('-',10));

            MyClass.Nested nested = new MyClass.Nested();
            nested.MethodFromNested();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый класс BaseClass
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Метод MethodFromBase 
        /// </summary>
        public void MethodFromBase()
        {
            Console.WriteLine("Method From Base Class");
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass : BaseClass
    {
        /// <summary>
        /// Класс Nested - вложенный в MyClass,
        /// наследование от BaseClass не распространяется.
        /// </summary>
        public class Nested
        {
            /// <summary>
            /// Метод во вложенном классе
            /// </summary>
            public void MethodFromNested()
            {
                Console.WriteLine("Method From Nested Class");
            }
        }
    }
}
