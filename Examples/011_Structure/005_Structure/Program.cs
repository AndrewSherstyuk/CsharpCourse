using System;

/// <summary>
/// Структура - статика
/// Структура не может быть статической, но структура может 
/// содержать статические члены.
/// </summary>
namespace _005_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структуры с вызовом 
            // конструктора по умолчанию.
            MyStruct myStruct = new MyStruct();
            
            //Инициализация статических полей необязательна.
            MyStruct.Display();

            MyStruct.Field = "Hello from field structure";

            MyStruct.Display();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct
    {
        /// <summary>
        /// Статическое автосвойство 
        /// </summary>
        public static string Field { get; set; }

        /// <summary>
        /// Статический меод Display
        /// </summary>
        public static void Display()
        {
            Console.WriteLine(Field);
        }

    }
}
