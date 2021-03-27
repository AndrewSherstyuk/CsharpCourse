using System;

/// <summary>
/// Оператор as 
/// Оператор as используется для выполнения преобразований между совместимыми ссылочными типами.
/// Оператор as подобен оператору приведения. Однако, если преобразование невозможно,
/// as возвращает значение null, а не вызывает исключение.
/// </summary>
namespace _010_Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            BaseClass baseClass = derivedClass as BaseClass;

            baseClass = derivedClass as BaseClass;

            //Задержка
            Console.ReadKey();
        }
    }


    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// </summary>
    class DerivedClass : BaseClass { }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass { }
}
