using System;

/// <summary>
/// Упаковка/Распаковка
/// </summary>
namespace _028_Boxing
{
    class Program
    {
        static void Main()
        {
            MyStruct myStruct = new MyStruct();

            // Упаковка (Boxing).
            ValueType boxed = myStruct;

            // Распаковка объекта (UnBoxing).
            MyStruct unBoxed = (MyStruct)boxed;

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct //: ValueType
    {
        /// <summary>
        /// Метод Method() из MyStruct
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}
