using System;

/// <summary>
/// Частичные классы
/// Классы могут быть частичными. То есть мы можем иметь несколько файлов с 
/// определением одного и того же класса, и при компиляции все эти 
/// определения будут скомпилированы в одно.
/// </summary>
namespace _015_Classes
{
    class Program
    {
        static void Main()
        {
            ////Создаем экземпляр класса MyClass с именем instance.
            PartialClass partialClass = new PartialClass();

            // Метод из первой части класса PartialClass
            partialClass.MethodFromFirstPart();
            // Метод со второй части класса PartialClass.
            partialClass.MethodFromSecondPart();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Частичный класс (1-я часть класса)
    /// </summary>
    partial class PartialClass
    {
        /// <summary>
        /// Метод из первой части класса PartialClass
        /// </summary>
        public void MethodFromFirstPart()
        {
            Console.WriteLine("Hellow from first part method ");
        }
    }

    /// <summary>
    /// Частичный класс (2-я часть класса)
    /// </summary>
    partial class PartialClass
    {
        /// <summary>
        /// Метод из второй части класса PartialClass
        /// </summary>
        public void MethodFromSecondPart()
        {
            Console.WriteLine("Hellow from second part method ");
        }
    }
}
