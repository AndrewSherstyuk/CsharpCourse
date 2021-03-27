using System;

/// <summary>
/// Наследование абстрактного класса от абстрактного класса возможна, 
/// при етом Реализация абстрактного метода из базового абстрактного класса, 
/// в производном абстрактном классе - не обязательна.
/// </summary>
namespace _003_Abstraction
{
    class Program
    {
        static void Main()
        {
            //Конкретный класс
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.AbstractBaseMethod();
            concreteClass.AbstractConcreteMethod();

            Console.WriteLine(new string('-', 20));

            //Конкретный абстрактный класс
            ConcreteAbstractClass concreteAbstractClass = new ConcreteClass();
            concreteAbstractClass.AbstractBaseMethod();
            concreteAbstractClass.AbstractConcreteMethod();

            Console.WriteLine(new string('-', 20));

            //Базовый абстрактный класс
            BaseAbstractClass baseAbstractClass = new ConcreteClass();
            baseAbstractClass.AbstractBaseMethod();
           
            Console.WriteLine(new string('-', 20));

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый абстарктный класс
    /// </summary>
    abstract class BaseAbstractClass
    {
        /// <summary>
        /// Метод в базовом абстрактном классе
        /// </summary>
        public abstract void AbstractBaseMethod();
    }

    /// <summary>
    /// Конкретный абстрактный класс, унаследованый от абстрактного
    /// класса BaseAbstractClass
    /// </summary>
    abstract class ConcreteAbstractClass: BaseAbstractClass
    {
        /// <summary>
        /// Метод в конкретном абстрактном классе
        /// </summary>
        public abstract void AbstractConcreteMethod();
    }

    /// <summary>
    /// Конкретный класс, унаследованный от класса 
    /// ConcreteAbstractClass
    /// </summary>
    class ConcreteClass : ConcreteAbstractClass
    {
        /// <summary>
        /// Реализация метода из базового абстрактного класса
        /// </summary>
        public override void AbstractBaseMethod()
        {
            Console.WriteLine("Implementation method from BaseAbstractClass");
        }

        /// <summary>
        /// Реализация метода из конкретного абстрактного класса
        /// </summary>
        public override void AbstractConcreteMethod()
        {
            Console.WriteLine("Implementation method from ConcreteAbstractClass");
        }
    }
}
