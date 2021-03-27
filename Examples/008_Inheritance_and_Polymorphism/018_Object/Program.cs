using System;

/// <summary>
/// GetType
/// Базовый класс Object.
/// </summary>
namespace _018_Object
{
    class Program
    {
        static void Main()
        {
            Object obj = new Object();

            Type type = obj.GetType();

            Console.WriteLine(type.ToString());
            
            Console.WriteLine(obj.GetType());

            // Задержка
            Console.ReadKey();
        }
    }
}
