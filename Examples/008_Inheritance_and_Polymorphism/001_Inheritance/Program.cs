using System;

/// <summary>
/// Наследование (inheritance) является одним из ключевых моментов ООП. 
/// Благодаря наследованию один класс может унаследовать функциональность 
/// другого класса.
/// </summary>
namespace _001_Inheritance
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса BaseClass с именем baseClass.
            BaseClass baseClass = new BaseClass();
            //Значение переменной publicField из базового класса
            Console.WriteLine(baseClass.publicField);

            //Создаем экземпляр класса DerivedClass с именем derivedClass.
            DerivedClass derivedClass = new DerivedClass();
            //Значение переменной publicField из базового класса
            Console.WriteLine(derivedClass.publicField);

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
        /// <summary>
        /// Конструктор унаследованного класса
        /// </summary>
        public DerivedClass()
        {
            // В конструкторе изменяем все доступные 
            // поля унаследованные от базового класса.
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
            //privateField = "";
        }
    }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        // Открытое поле базового класса.
        public string publicField = "BaseClass.publicField";

        // Закрытое поле базового класса.
        private string privateField = "BaseClass.privateField";

        // Защищенное поле базового класса.
        protected string protectedField = "BaseClass.protectedField";
    }
}
