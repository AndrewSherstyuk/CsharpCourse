using System;

/// <summary>
///  Наследование от интерфейсов c одноименными методами.
///  Объединение реализации методов членов.
/// </summary>
namespace _013_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Method();

            Console.WriteLine(new string('-', 10));

            Interface1 interface1 = (Interface1)myClass;
            interface1.Method();

            Console.WriteLine(new string('-', 10));

            Interface2 interface2 = (Interface2)myClass;
            interface2.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass - наследуется от Interface1 и Interface2
    /// </summary>
    class MyClass : Interface1, Interface2
    {
        /// <summary>
        ///  Объединение реализации от Interface1 и Interface2
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface (1-2)");
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
    /// Интерфейс 2 
    /// </summary>
    interface Interface2
    {
        void Method();
    }
}
