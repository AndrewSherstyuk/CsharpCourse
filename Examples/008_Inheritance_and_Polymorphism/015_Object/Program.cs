using System;

/// <summary>
/// Базовый класс Object.
/// Переопределение метода ToString()
/// </summary>
namespace _015_Object
{
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance.GetHashCode());

            //Задежка
            Console.ReadKey();
        }
    }
    class MyClass
    {
        /*public override int GetHashCode()
        {
            return 123;
        }*/
    }
}
