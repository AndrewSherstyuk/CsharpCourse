using System;

/// <summary>
/// Вложенные структуры
/// Структура может содержать вложенный класс.
/// </summary>
namespace _015_Nested
{
    class Program
    {
        static void Main()
        {
            MyStruct.Nested nested = new MyStruct.Nested();
            nested.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Внешняя структура MyStruct
    /// </summary>
    public struct MyStruct
    {
        /// <summary>
        /// Вложенный класс Nested
        /// </summary>
        public class Nested
        {
            /// <summary>
            /// Method во вложенно классе
            /// </summary>
            public void Method()
            {
                Console.WriteLine("Method from nested class");
            }
        }
    }
}
