
using System;

/// <summary>
/// Ключевое слово base 
/// Вызывается пользовательский конструктор базового класса, при этом не нужно, 
/// присваивать значения, унаследованным членам в конструкторе производного класса.
/// </summary>
namespace _004_Inheritance
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса DerivedClass с именем derivedClassWitArguments.
            DerivedClass derivedClassWitArguments = new DerivedClass(1, 2);

            Console.WriteLine(derivedClassWitArguments.baseNumber);
            Console.WriteLine(derivedClassWitArguments.derivedField);

            Console.WriteLine(new string('*',30));

            //Создаем экземпляр класса DerivedClass с именем derivedClassWithoutArguments.
            DerivedClass derivedClassWithoutArguments = new DerivedClass();

            Console.WriteLine(derivedClassWithoutArguments.baseNumber);
            Console.WriteLine(derivedClassWithoutArguments.derivedField);

            // Задержка.
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
        /// Конструктор по умолчанию унаследованного класса
        /// </summary>
        public DerivedClass()
        {
            Console.WriteLine("base derived constructor");
        }

        /// Пользовательский конструктор унаследованного класса
        /// ключевое слово base!
        /// </summary>
        public DerivedClass(int number1, int number2)
            : base(number1)
        {
            Console.WriteLine("derived customer constructor");
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
        /// Конструктор по умолчанию  базового класс
        /// </summary>
        public BaseClass()
        {
            Console.WriteLine("base default constructor");
        }

        /// <summary>
        /// Пользовательский конструктор базового класс.
        /// </summary>
        /// <param name="number"></param>
        public BaseClass(int number)
        {
            Console.WriteLine("base customer constructor");
            this.baseNumber = number;
        }
    }
}
