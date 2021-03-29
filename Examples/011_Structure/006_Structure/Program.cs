using System;

/// <summary>
/// Структура - статический конструктор
/// </summary>
namespace _006_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структуры, 
            // с вызовом пользовательского конструктора.
            MyStruct myStruct = new MyStruct("Hello from field structure");

            Console.WriteLine(new string('-',10));

            Console.WriteLine(myStruct.field);

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
        /// Поле структуры 
        /// </summary>
        public string field;
        
        /// <summary>
        /// Статический конструктор структуры 
        /// </summary>
        static MyStruct()
        {
            Console.WriteLine("Static constructor struct");
        }

        /// <summary>
        /// Пользовательский конструктор 
        /// </summary>
        /// <param name="value"></param>
        public MyStruct(string value)
        {
            Console.WriteLine("Constructor struct");
            this.field = value;
        }
    }
}
