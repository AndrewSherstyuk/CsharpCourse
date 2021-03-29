using System;

/// <summary>
/// Вложенные структуры
/// Одна структура может быть вложенна в другую структуру.
/// </summary>
namespace _014_Nested
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
        /// Вложенная структура Nested
        /// </summary>
        public struct Nested
        {
            /// <summary>
            /// Method во вложенной структуре
            /// </summary>
            public void Method()
            {
                Console.WriteLine("Method from nested struct");
            }
        }
    }
}
