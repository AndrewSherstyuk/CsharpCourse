using System;

/// <summary>
/// Оператор is 
/// Оператор is - проверяет совместимость объекта с заданным типом. 
/// Если предоставленный объект может быть приведен к предоставленному типу не вызывая исключение,
/// выражение is принимает значение true.
/// </summary>
namespace _009_Inheritance_and_Polymorphism
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            BaseClass baseClass;

            if (derivedClass is BaseClass)
            {
                baseClass = (BaseClass)derivedClass;
            }
            else
            {
                baseClass = null;
            }
        }
    }


    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// </summary>
    class DerivedClass : BaseClass { }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass{}

    class MyClass
    {}
}
