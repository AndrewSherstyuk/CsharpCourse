using System;

/// <summary>
/// Пользовательский конструктор.
/// При создании объекта производного класса, конструктор производного класса 
/// автоматически вызывает конструктор по умолчанию из базового класса.
/// Конструктор базового класса, присвоит всем данным какие-то свои безопасные значения.
/// После этого начнет работу конструктор производного класса, который повторно
/// будет определять значения для унаследованых членов. (ДВОЙНАЯ РАБОТА)!
/// </summary>
namespace _003_Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass(1, 2);

            Console.WriteLine(derivedClass.baseNumber);
            Console.WriteLine(derivedClass.derivedField);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// (BaseClass)
    /// </summary>
    class DerivedClass : BaseClass
    {
        public int derivedField;

        /// <summary>
        /// Пользовательский конструктор унаследованного класса
        /// </summary>
        public DerivedClass(int number1, int number2)
        {
            Console.WriteLine("derived customer constructor");

            // Инициализируем поле базового класса.
            baseNumber = number1;

            // Инициализируем поле производного (данного) класса.
            derivedField = number2;
        }
    }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        public int baseNumber;

        /// <summary>
        /// Конструктор по умолчанию базового класса.
        /// </summary>
        public BaseClass()
        {
            Console.WriteLine("base default constructor");
        }

        /// <summary>
        /// Пользовательский конструктор базового класса.
        /// </summary>
        /// <param name="baseNumber"></param>
        public BaseClass(int baseNumber)
        {
            Console.WriteLine("base customer constructor");
            this.baseNumber = baseNumber;
        }
    }
}
