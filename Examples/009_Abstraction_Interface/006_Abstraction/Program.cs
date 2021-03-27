using System;

/// <summary>
/// Конструктор абстратного класса
/// </summary>
namespace _006_Abstraction
{
    class Program
    {
        static void Main()
        {
            ConcreteClass сoncreteClass = new ConcreteClass();
            Console.WriteLine(new string('*', 20));
            сoncreteClass.AbstractMethod();

            Console.WriteLine(new string('-', 20));

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class AbstractClass
    {
        /// <summary>
        /// Конструктор базового класса
        /// </summary>
        public AbstractClass()
        {
            Console.WriteLine("Начало конструктора из AbstractClass");

            //Вызов реализации 
            this.AbstractMethod();

            Console.WriteLine("Конструктор конструктора из AbstractClass");
        }

        /// <summary>
        /// Метод абстрактного класса
        /// </summary>
        public abstract void AbstractMethod();
    }

    /// <summary>
    /// Конкретный класс, наследуется от базового абстрактного класса
    /// </summary>
    class ConcreteClass: AbstractClass
    {
        /// <summary>
        /// Поле 
        /// </summary>
        string field = "field from ConcreteClass";

        /// <summary>
        /// Конструктор базового класса 
        /// </summary>
        public ConcreteClass()
        {
            Console.WriteLine("Конструктор из ConcreteClass");
        }

        /// <summary>
        /// Реализация метода из базового класса 
        /// </summary>
        public override void AbstractMethod()
        {
            Console.WriteLine("Значение поля из конкретного класса - {0}", field);
        }
    }
}
