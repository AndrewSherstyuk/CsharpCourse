using System;

/// <summary>
/// Структуры. Наследование.
/// Структура может наследоватся только от интерфейса, наследование
/// структур от структур и классов запрещено.
/// </summary>
namespace _011_Inheritance
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа
            MyStruct myStruct = new MyStruct();

            //Вызов метода на екземпляре структуры
            myStruct.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Пользовательский интерфес IInterface
    /// </summary>
    interface IInterface
    {
        void Method();
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct : IInterface
    {
        /// <summary>
        /// Метод из структуры
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Method from IInterface");
        }
    }
}
