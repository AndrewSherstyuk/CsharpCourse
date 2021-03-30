using System;

/// <summary>
/// Реализация одноименных методов в различных интерфейсах
/// </summary>
namespace _009_Interfaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.MethodIntef1();

            // На экземпляре myClass нету методов интерфейсов.
            //myClass.Method();

            Interface1 instance1 = new MyClass();
            instance1.Method();

            Console.WriteLine(new string('-', 10));

            //UpCast
            Interface1 instance11 = (Interface1)myClass;
            instance11.Method();

            Console.WriteLine(new string('-', 10));

            //Или приведение экземпляра к базовому интерфейсному типу 
            Interface1 instance111 = instance11 as Interface1;
            instance11.Method();

            Console.WriteLine(new string('-', 10));

            Interface2 instance2 = new MyClass();
            instance2.Method();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// MyClass - класс в котором реализуем интерфейсы Interface1 и Interface2.
    /// При реализации методов используем технику явного указания имени интерфейса в имени
    /// метода, которому принадлежит данный метод.
    /// Одноименные методы private - по умолчанию, 
    /// при попытке явно указать модификатор доступа - ошибка уровня компиляции
    /// </summary>
    class MyClass : Interface1, Interface2
    {
        /// <summary>
        /// Реализация Method из интерфейса Interface1
        /// </summary>
        void Interface1.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface1");
        }

        /// <summary>
        /// Реализация Method из интерфейса Interface2
        /// </summary>
        void Interface2.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface2");
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
