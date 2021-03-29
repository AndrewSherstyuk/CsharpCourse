using System;

/// <summary>
/// Деструктор в структурах
/// </summary>
namespace _002_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Структура не может содержать деструктор");
            Console.WriteLine("Деструктор не может иметь аргументов");
            Console.WriteLine("Деструктор не может быть статическим");
            Console.WriteLine("Деструктор не может иметь модификаторы доступа");
           
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
        /// Структура не может содержать деструктор
        /// </summary>
        //~MyStruct()
        //{
        //
        //}
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Деструктор не может иметь аргументов
        /// </summary>
        //~MyClass(int argument)
        //{
        //
        //}

        /// <summary>
        /// Деструктор не может быть статическим
        /// </summary>
        //static ~MyClass()
        //{
        //
        //}

        /// <summary>
        /// Деструктор не может иметь модификаторы доступа
        /// </summary>
        //public ~MyClass()
        //{
        //
        //}
    }
}
