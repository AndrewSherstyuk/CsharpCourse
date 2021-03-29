using System;

/// <summary>
/// Структура - конструктор
/// </summary>
namespace _004_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структуры с вызовом 
            // пользовательского конструктора.
            MyStruct myStruct = new MyStruct("Hello from field structure");

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
        /// Пользловательский конструктор структуры
        /// </summary>
        public MyStruct(string value)
        {
            //Оттеняем вызов конструктора структуры
            Console.WriteLine("Struct constructor");
            //Display();
            this.field = value;
            //Вызов метода Display в констуркторе;
            Display();
        }

        /// <summary>
        /// Метод для отображения значения поля структуры
        /// </summary>
        public void Display()
        {
            Console.WriteLine(field);
        }
    }
}
