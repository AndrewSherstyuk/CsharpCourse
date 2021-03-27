using System;

/// <summary>
/// Варианты методов абстрактного класса
/// </summary>
namespace _005_Abstraction
{
    class Program
    {
        static void Main()
        {
            //Конкретный класс
            DerivedClass derivedClass = new DerivedClass();

            derivedClass.SimpleMethod();
            derivedClass.VirtualMethod();
            derivedClass.AbstractMethod();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Конкретный класс, которыйй наследуется от абстрактного класса
    /// AbstractBaseClass
    /// </summary>
    class DerivedClass : AbstractBaseClass
    {

        /// <summary>
        /// Переопределение virtual метода из базового абстрактного класса,
        /// если метод не переопределяется, тогда используется логика из
        /// базового класса
        /// </summary>
        public override void VirtualMethod()
        {
            Console.WriteLine("VirtualMethod from DerivedClass");
        }

        /// <summary>
        /// Реализация абстрактного метода из базового абстактного класса
        /// </summary>
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMethod from DerivedClass");
        }
    }

    /// <summary>
    /// Базовый абстрактный класс
    /// </summary>
    abstract class AbstractBaseClass
    {
        /// <summary>
        /// Обичный метод из базового абстактного класса
        /// ( передается производному классу как 
        /// при наследовании от конкретного класса)
        /// </summary>
        public void SimpleMethod()
        {
            Console.WriteLine("SimpleMethod from AbstractBaseClass");
        }

        /// <summary>
        /// Виртуальный метод из базового абстактного класса
        /// (передается производному классу как при 
        /// наследовании от конкретного класса)
        /// </summary>
        virtual public void VirtualMethod()
        {
            Console.WriteLine("VirtualMethod from AbstractBaseClass");
        }

        /// <summary>
        /// Абстрактный метод из базового абстактного класса
        /// (реализуется в производном классе)
        /// </summary>
        abstract public void AbstractMethod();
    }
}
