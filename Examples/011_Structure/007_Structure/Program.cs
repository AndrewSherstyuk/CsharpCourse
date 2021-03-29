using System;

/// <summary>
/// Структура 
/// </summary>
namespace _007_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа 
            // без вызова конструктора.
            MyStruct myStruct;

            // Нельзя использовать не инициализированную 
            // переменную, так как конструктор не вызывался 
            //переменная field осталась не инициализированной.

            //Console.WriteLine(myStruct.field);

            //Сначала инициализируем переменную
            myStruct.field = "Hello from field structure";
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
        /// Пользовательский конструктор с параметрами.
        /// </summary>
        /// <param name="value"></param>
        public MyStruct(string value)
        {
            this.field = value;

            Console.WriteLine(field);
        }
    }
}
