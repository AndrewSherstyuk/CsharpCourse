using System;

/// <summary>
/// Деструктор - необработанное исключение,
/// приводит к остановке работы деструктора
/// </summary>
namespace _004_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Деструктор
        /// </summary>
        ~MyClass()
        {
            throw new Exception();

            //Недостижимий код
            Console.WriteLine("Destructor from MyClass");
        }
    }


}
