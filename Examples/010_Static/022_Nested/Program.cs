using System;

/// <summary>
/// Вложенные классы.
/// Нестатические классы могут в себе содержать статические Nested классы.
/// </summary>
namespace _022_Nested
{
    class Program
    {
        static void Main()
        {
            MyClass.StaticNested.StaticMethodFromNested();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass 
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// Статический вложенный класс StaticNested в нестатическом
        /// классе MyClass
        /// </summary>
        public static class StaticNested
        {
            /// <summary>
            /// Статический метод в статичесом вложенном классе
            /// </summary>
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Статический метод Nested класса.");
            }
        }
    }
}
