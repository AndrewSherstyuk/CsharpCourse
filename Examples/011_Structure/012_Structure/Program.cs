using System;

/// <summary>
/// Структура
/// Как и классы, структуры — это сущности для хранения данных, 
/// которые могут содержать данные-члены и функции-члены. 
/// Но в отличие от классов, структуры являются типами значений
/// и для них не выделяется память из кучи.
/// </summary>
namespace _012_Structure
{
    class Program
    {
        static void Main()
        {
            MyStruct myStruct;
            
            //Инициализация поля 
            myStruct.field = "Hello from field structure";

            //Если закомментировать, инициализацию поля, попытатся
            //вывести неинецеализированное поле, то ето привед
            //к ошыбке
            Console.WriteLine(myStruct.field);

            //Задержка
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public string field = "10";
    }
    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct
    {
        /// <summary>
        /// Поле field типа string
        /// В структурах нельзя инициализировать поля 
        /// непосредственно в месте создания.
        /// </summary>
        public string field;
    }
}
