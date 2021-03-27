using System;

/// <summary>
/// new при одноименных методах в интерфейсах
/// </summary>
namespace _012_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            //myClass.Method();

            Interface1 interface1 = myClass as Interface1;
            interface1.Method();

            Console.WriteLine(new string('-', 10));

            Interface2 instance2 = myClass as Interface2;
            instance2.Method();

            // Задержка
            Console.ReadKey();
        }
    }

    class MyClass : Interface2
    {
        void Interface1.Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface1");
        }
        void Interface2.Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface2");
        }

    }

    /// <summary>
    /// Интерфейс 1
    /// </summary>
    interface Interface1
    {
        void Method();
    }

    /// <summary>
    /// Интерфейс 2 наследуется от Интерфейс 1
    /// </summary>
    interface Interface2 : Interface1
    {
        new void Method();
    }
}
