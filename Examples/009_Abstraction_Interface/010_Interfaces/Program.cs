using System;

/// <summary>
/// Множественное наследование 
/// Множественное наследование допустимо только от интерфейсов, 
/// допустимо множественное наследование от одного класса и многих интерфейсов,
/// но недопустимо множественное наследование от многих классов.
/// </summary>
namespace _010_Interfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.BaseMethod();
            derivedClass.Method1();
            derivedClass.Method2();

            Console.WriteLine(new string('-', 10));

            BaseClass baseClass = (BaseClass)derivedClass;
            baseClass.BaseMethod();
            
            Console.WriteLine(new string('-', 10));

            Interface1 interface1 = (Interface1)baseClass;
            interface1.Method1();

            Console.WriteLine(new string('-', 10));

            Interface2 interface2 = (Interface2)baseClass;
            interface2.Method2();

            //Задержка 
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Дочерний класс, множественное наследование.
    /// </summary>
    class DerivedClass : BaseClass, Interface1, Interface2
    {
        /// <summary>
        /// Реализация метода Method1() из Interface1
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        /// <summary>
        /// Реализация метода Method2() из Interface1
        /// </summary>
        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
        }
    }

    /// <summary>
    /// Базовый класс 
    /// </summary>
    class BaseClass
    {
        /// <summary>
        /// Метод из базового класса
        /// </summary>
        public void BaseMethod()
        {
            Console.WriteLine("Метод класса - BaseClass.");
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
