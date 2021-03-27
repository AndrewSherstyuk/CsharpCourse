using System;

/// <summary>
/// Вложенные классы.
/// Наследование от вложенных классов
/// </summary>
namespace _019_Nested
{
    class Program
    {
        static void Main()
        {
            MyClass.Nested nested = new MyClass.Nested();
            nested.MethodFromBase();
            nested.MethodFromNested();

            MyClass myClass = new MyClass();
            

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
    class MyClass
    {
        /// <summary>
        /// Класс Nested - вложенный в MyClass
        /// </summary>
        public class Nested : BaseClass
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
