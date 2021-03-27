using System;

/// <summary>
/// Интерфейс представляет ссылочный тип, который может определять 
/// некоторый функционал - набор методов и свойств без реализации. 
/// Затем этот функционал реализуют классы и структуры, которые 
/// применяют данные интерфейсы.
/// </summary>
namespace _007_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            myClass.Method();

            IInterface @interface = (IInterface)myClass;
            @interface.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Интерфейс
    /// </summary>
    interface IInterface
    {
        /// <summary>
        /// Метод для реализации в унаследованном классе
        /// </summary>
        void Method();
    }

    /// <summary>
    /// Класс MyClass - реализует интерфейс IInterface
    /// </summary>
    class MyClass : IInterface
    {
        /// <summary>
        /// Реализация 
        /// </summary>
        /* public void Method()
         {
             Console.WriteLine("Реализация метода Method из IInterface");
         }*/
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}
