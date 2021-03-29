using System;

/// <summary>
/// Деструктор в Object
/// </summary>
namespace _006_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
        }
    }

    /// <summary>
    /// В Object - есть свой деструктор, но он не вызивается,
    /// для унаследованных классов, в производных классах необходимо
    /// создавать собственный деструктор 
    /// </summary>
    class MyClass : Object
    {

    }
}
