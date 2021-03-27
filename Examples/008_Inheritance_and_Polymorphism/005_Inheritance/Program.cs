using System;

/// <summary>
/// Upcast
/// Объекты производного типа (который находится внизу иерархии) в то же время представляют и базовый тип.
/// </summary>
namespace _005_Inheritance
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса DerivedClass с именем derivedClass.
            DerivedClass derivedClass = new DerivedClass();

            //Присваиваем значение свойствам базового класса
            derivedClass.field1 = 1;
            derivedClass.field2 = 2;
            derivedClass.field3 = 3;

            //Присваиваем значение свойствам унаследованного класса
            derivedClass.field4 = 4;
            derivedClass.field5 = 5;

            //Создаем экземпляр класса BaseClass с именем baseClass.
            // Upcast - DerivedClass к BaseClass
            BaseClass baseClass = (BaseClass)derivedClass;

            //Выводим значение полей baseClass
            Console.WriteLine(baseClass.field1);
            Console.WriteLine(baseClass.field2);
            Console.WriteLine(baseClass.field3);

            Console.WriteLine(new string('*',30));

            //При приведении к DerivedClass к BaseClass не видны 
            //Console.WriteLine(baseClass.field4);
            //Console.WriteLine(baseClass.field5);

            DerivedClass derivedClassFromBaseClass = (DerivedClass)baseClass;

            Console.WriteLine(derivedClassFromBaseClass.field1);
            Console.WriteLine(derivedClassFromBaseClass.field2);
            Console.WriteLine(derivedClassFromBaseClass.field3);

            Console.WriteLine(derivedClassFromBaseClass.field4);
            Console.WriteLine(derivedClassFromBaseClass.field5);

            Console.WriteLine(new string('*', 30));

            // Проверка.
            Console.WriteLine("Hash сode derived Class = {0}", derivedClass.GetHashCode());
            Console.WriteLine("Hash сode base Class = {0}", baseClass.GetHashCode());

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
        /// <summary>
        /// Поле 4 (DerivedClass)
        /// </summary>
        public int field4;

        /// <summary>
        /// Поле 4 (DerivedClass)
        /// </summary>
        public int field5;
    }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        /// <summary>
        /// Поле 1 (BaseClass)
        /// </summary>
        public int field1;

        /// <summary>
        /// Поле 2 (BaseClass)
        /// </summary>
        public int field2;

        /// <summary>
        /// Поле 3 (BaseClass)
        /// </summary>
        public int field3;
    }
}
