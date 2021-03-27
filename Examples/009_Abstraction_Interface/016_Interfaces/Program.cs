using System;

/// <summary>
///  Наследование от класса и интерфейса у которых совпадают сигнатуры членов.
/// </summary>
namespace _016_Interfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();

            Console.WriteLine(new string('-', 10));

            BaseClass baseClass = (BaseClass)derivedClass;
            baseClass.Method();

            Console.WriteLine(new string('-', 10));

            Interface @interface = (Interface)baseClass;
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
    /// Базовый класс 
    /// </summary>
    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }

    /// <summary>
    /// DerivedClass унаследованный класс от BaseClass и Interface
    /// </summary>
    class DerivedClass : BaseClass, Interface
    {
        // Реализация интерфейса не обязательна, т.к., 
        // сигнатуры методов в классе и интерфейсе совпадают.
        /*public new void Method()
        {
            Console.WriteLine("DerivedClass.Method()");
        }*/
    }
}
