using System;

/// <summary>
/// Наследование интерфейса от интерфейса.
/// </summary>
namespace _011_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();

            Console.WriteLine(new string('-', 10));

            Interface1 interface1 = myClass as Interface1;
            interface1.Method1();

            Console.WriteLine(new string('-', 10));

            Interface2 interface2 = myClass as Interface2;
            interface2.Method1();
            interface2.Method2();

            //Задержка 
            Console.ReadKey();
        }
    }

    class MyClass : Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 - реализация интерфейса IInterface1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 - реализация интерфейса IInterface2");
        }
    }

    /// <summary>
    /// Интерфейс 1
    /// </summary>
    interface Interface1
    {
        void Method1();
    }

    /// <summary>
    /// Интерфейс 2 наследуется от Интерфейс 1
    /// </summary>
    interface Interface2 : Interface1
    {
        void Method2();
    }
}
