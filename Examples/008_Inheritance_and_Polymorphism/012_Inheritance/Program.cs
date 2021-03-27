using System;

/// <summary>
/// Модификатор sealed
/// </summary>
namespace _012_Inheritance
{
    class Program
    {
        static void Main()
        {
            SealedClass sealedClass = new SealedClass();
            Console.WriteLine(sealedClass.MyProperty);
            sealedClass.Display();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// Попытка наследования от SealedClass приводит к ошибке компилятора.
    /// </summary>
    class DerivedClass //: SealedClass 
    { }

    /// <summary>
    /// SealedClass - базовый класс
    /// </summary>
    sealed class SealedClass 
    {
        public int MyProperty { get; set; } = 100;

        public void Display()
        {
            Console.WriteLine(MyProperty);
        }
    }
}
