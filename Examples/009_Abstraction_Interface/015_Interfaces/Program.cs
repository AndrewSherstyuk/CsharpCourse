using System;

/// <summary>
/// Наследование абстрактных классов от интерфейсов.
/// </summary>
namespace _015_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Method();

            Console.WriteLine(new string('-', 10));

            AbstractClass abstractClass = (AbstractClass)myClass;
            abstractClass.Method();

            Console.WriteLine(new string('-', 10));

            Interface @interface = (Interface)myClass;
            @interface.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Интерфейс
    /// </summary>
    interface Interface
    {
        void Method();
    }

    /// <summary>
    /// AbstractClass, унаследованный от Interface, 
    /// замещение абстрактного метода из интерфейса.
    /// </summary>
    abstract class AbstractClass : Interface
    {
        public abstract void Method();
    }

    /// <summary>
    /// Класс MyClass - наследуется от базового класса -AbstractClass,
    /// реализация абстрактного метода из абстрактного класса, 
    /// в конкретном классе обязательна.
    /// </summary>
    class MyClass : AbstractClass
    {
        /// <summary>
        /// Реализация метода из абстрактного класса
        /// </summary>
        public override void Method()
        {
            Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
        }
    }
}
