using System;

/// <summary>
/// Фабричный метод 
/// </summary>
namespace _007_Static
{
    class Program
    {
        static void Main()
        {
            AbstractClass abstractClass = AbstractClass.Create();
            abstractClass.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Абстрактный класс AbstractClass
    /// </summary>
    abstract class AbstractClass
    {
        /// <summary>
        /// Метод для реализации в конкретном классе
        /// </summary>
        public abstract void Method();

        /// <summary>
        /// Статический фабричный метод абстрактного класса, для 
        /// создает экземпляр конкретного класса
        /// </summary>
        /// <returns></returns>
        public static AbstractClass Create()
        {
            return new ConcreteClass();
        }
    }

    /// <summary>
    /// Конкретній класс - ConcreteClass, наследуется от абстрактного
    /// класса AbstractClass
    /// </summary>
    class ConcreteClass : AbstractClass
    {
        /// <summary>
        /// Реазиация метода из абстрактного класса 
        /// </summary>
        public override void Method()
        {
            Console.WriteLine("implementation from AbstractClass");
        }
    }
}
