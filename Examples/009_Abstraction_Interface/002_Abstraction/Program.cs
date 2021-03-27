using System;

/// <summary>
/// Наследование абстрактного класса от конкретного класса 
/// </summary>
namespace _002_Abstraction
{
    class Program
    {
        static void Main()
        {
            //Конкретный класс
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.MethodFromConcreteClass();
            concreteClass.AbstractMethod();
            concreteClass.BaseMethod();
            
            Console.WriteLine(new string('-', 20));

            //Абстактний класс
            AbstractСlass abstractСlass = new ConcreteClass();
            abstractСlass.AbstractMethod();
            abstractСlass.BaseMethod();

            Console.WriteLine(new string('-', 20));

            //Базовый класс - UpCast - AbstractСlass
            BaseClass baseClass = (BaseClass)abstractСlass;
            baseClass.BaseMethod();

            //Задержка
            Console.ReadKey();
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
            Console.WriteLine("BaseMethod from BaseClass");
        }
    }

    /// <summary>
    /// Абстрактный класс, наследуется от базового класса - BaseClass
    /// </summary>
    abstract class AbstractСlass: BaseClass
    {
        /// <summary>
        /// Абстрактный метод 
        /// </summary>
        public abstract void AbstractMethod();
    }

    /// <summary>
    /// Конкретный класс, наследуется от абстрактного класса
    /// </summary>
    class ConcreteClass : AbstractСlass
    {
        /// <summary>
        /// Реализация абстракного метода из абстрактного класса
        /// AbstractСlass
        /// </summary>
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMethod from ConcreteClass");
        }

        /// <summary>
        /// Метод конкретного класса
        /// </summary>
        public void MethodFromConcreteClass()
        {
            Console.WriteLine("MethodFromConcreteClass");
        }
    }
}
