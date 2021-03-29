using System;
using System.Threading;

namespace _014_GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            //Деструктор вызивается автоматически
            //myClass.~MyClass();

            Thread.Sleep(1000);
     
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
            Console.WriteLine("Destructor from MyClass");
            Console.ReadKey();
        }
    }
}
