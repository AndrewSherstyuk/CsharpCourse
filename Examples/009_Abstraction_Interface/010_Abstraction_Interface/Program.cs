using System;

/// <summary>
/// Кроме обычных классов в C# есть абстрактные классы. Абстрактный класс похож на обычный класс. 
/// Он также может иметь переменные, методы, конструкторы, свойства. 
/// Единственное, что при определении абстрактных классов используется ключевое слово abstract.
/// Но главное отличие состоит в том, что мы не можем использовать конструктор абстрактного 
/// класса для создания его объекта.
/// Конкретный класс должен реализовать абстрактный класс, иначе ошибка уровня компиляции
/// </summary>
namespace _010_Abstraction_Interface
{
    class Program
    {
        static void Main()
        {
            //При попытке создать экземпляр абстрактного класса, ошибка уровня компиляции
            //AbstractClass abstractClass = new AbstractClass();

            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.Method();
            concreteClass.MethodFromConcreteClass();

            Console.WriteLine(new string('-', 20));

            //Или так
            Object obj = new ConcreteClass();

            AbstractClass abstractClass = new ConcreteClass();
            abstractClass.Method();
            
            //abstractClass.MethodFromConcreteClass();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Конкретный класс - реализовывает абстрактный класс AbstractClass
    /// </summary>
    class ConcreteClass : AbstractClass
    {
        /// <summary>
        /// Реализация метода из абстрактного класса
        /// </summary>
        public override void Method()
        {
            Console.WriteLine("Implementation Method from an abstract class");
        }


        /// <summary>
        /// Метод конкретного класса
        /// </summary>
        public void MethodFromConcreteClass()
        {
            Console.WriteLine("MethodFromConcreteClass");
        }
    }

    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class AbstractClass
    {
        public abstract void Method();
    }

    public abstract class Car
    {
        public abstract void Engen();
        
    }

    public class Ford : Car
    {
        public override void Engen()
        {
            
        }
    }

    public class Pego : Car
    {
        public override void Engen()
        {
            
        }
    }
}
