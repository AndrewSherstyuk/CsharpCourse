using System;

/// <summary>
/// Множественное наследование интерфейсов 
/// </summary>
namespace _008_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();

            Console.WriteLine(new string('-', 10));

            Interface1 instance1 = new MyClass();
            instance1.Method1();
            //instance1.Method2();

            Console.WriteLine(new string('-', 10));

            Interface2 instance2 = (Interface2)new MyClass();
            //instance2.Method1();
            instance2.Method2();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс в котором реализуются Interface1 и Interface2
    /// </summary>
    class MyClass : Object, Interface1, Interface2
    {
        /// <summary>
        /// Реализвция метода 1 из Interface1
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        /// <summary>
        /// Реализвция метода 2 из Interface2
        /// </summary>
        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
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
    /// Интерфейс 2
    /// </summary>
    interface Interface2
    {
        void Method2();
    }
}
