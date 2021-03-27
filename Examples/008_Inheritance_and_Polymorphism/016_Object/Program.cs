using System;

/// <summary>
/// Базовый класс Object.
/// Переопределение метода ToString()
/// </summary>
namespace _016_Object
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.ToString());

            // Задежка
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public override string ToString()
        {
            return "Override method ToString()";
        }
    }
}
