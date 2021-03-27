using System;

/// <summary>
/// Вложенные классы.
/// Статические классы могут в себе содержать 
/// нестатические Nested классы.
/// </summary>
namespace _021_Nested
{
    class Program
    {
        static void Main()
        {
            StaticClass.Nested nested = new StaticClass.Nested();
            nested.MethodFromNested();

            Console.WriteLine(new string('-', 10));

            StaticClass.StaticMethod();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Статический класс StaticClass
    /// </summary>
    public static class StaticClass
    {
        /// <summary>
        /// Статический конструктор класса StaticClass
        /// </summary>
        static StaticClass()
        {
            Console.WriteLine("Статический конструктор StaticClass");
        }

        /// <summary>
        /// Статический метод класса StaticClass
        /// </summary>
        public static void StaticMethod()
        {
            Console.WriteLine("Статический метод класса StaticClass");
        }

        /// <summary>
        /// Класс Nested не статический, 
        /// вложенный в статический StaticClass,
        /// </summary>
        public class Nested
        {
            /// <summary>
            /// Не статический метод во вложенном классе
            /// </summary>
            public void MethodFromNested()
            {
                Console.WriteLine("Method From Nested class");
            }
        }
    }
}
