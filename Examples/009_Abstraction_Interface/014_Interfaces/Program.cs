using System;

/// <summary>
/// Наследование абстрактного класса от интерфейса.
/// </summary>
namespace _014_Interfaces
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
    /// Абстрактный класс, который наследуется от интерейса, 
    /// реализация абстрактного метода из интерфейса, в абстрактном классе обязательна.
    /// </summary>
    abstract class AbstractClass : Interface
    {
        /// <summary>
        /// Реализация абстрактного класса из интерфейса
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
        }
    }

    /// <summary>
    /// Класс MyClass, наследуется от абстрактного класса AbstractClass
    /// </summary>
    class MyClass : AbstractClass
    { }
}
