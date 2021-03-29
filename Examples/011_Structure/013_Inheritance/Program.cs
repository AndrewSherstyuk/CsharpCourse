using System;

/// <summary>
/// Структуры. Наследование.
/// От структур нельзя наследоваться.
/// Структуры не могут иметь protected членов.
/// </summary>
namespace _013_Inheritance
{
    class Program
    {
        static void Main()
        {
        }
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct
    {
        
        //protected int field;
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass //: MyStruct
    {
    }
}
