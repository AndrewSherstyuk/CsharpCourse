using System;

/// <summary>
/// Структура - конструктор
/// </summary>
namespace _003_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структуры с вызовом 
            // конструктора по умолчанию.
            MyStruct myStruct = new MyStruct();
            myStruct.field = "Hello from field structure";
            Console.WriteLine(myStruct.field);

            Console.WriteLine(new string('-', 10));

            // Создание экземпляра структуры с вызовом 
            // пользовательского конструктора.
            MyStruct myStructConstructor = new MyStruct("Hello from field structure");
            Console.WriteLine(myStructConstructor.field);

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
        /// Поле field типа string
        /// </summary>
        public string field;

        /// <summary>
        /// В структурах конструкторы по умолчанию нельзя 
        /// задавать явно.
        /// </summary>

        //public MyStruct()
        //{
        //}

        /// <summary>
        /// Если в структуре имеется пользовательский 
        /// конструктор, то требуется в нем инициализировать 
        /// все поля.
        /// </summary>
        public MyStruct(string value)
        {
            this.field = value;
        }
    }
}
