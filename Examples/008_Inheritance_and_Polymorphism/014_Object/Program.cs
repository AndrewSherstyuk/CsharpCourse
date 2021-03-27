using System;

/// <summary>
///  Базовый класс Object.
/// </summary>
namespace _014_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // Задержка.
            Console.ReadKey();
        }
    }

    class MyClass: Object
    {
        
    }
}
