using System;

/// <summary>
/// Частичные методы 
/// </summary>
namespace _01_Classes
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();
            
            instance.CallPartialMethod();

            //Задержка.
            Console.ReadKey();
        }
    }

    // Первая часть класса.
    partial class PartialClass
    {
        // Объявление частичного метода.        
        partial void PartialMethod();

        partial void MyMethod();
    }

    // Вторая часть класса.
    partial class PartialClass
    {
        // Определение частичного метода. 
        partial void PartialMethod()
        {
            Console.WriteLine("Вызван частичный метод - PartialMethod()");
        }

        // Вызов частичного метода через метод обертку.
        public void CallPartialMethod()
        {
            PartialMethod();

            // При вызове нереализованного частичного метода, компилятор его проигнорирует 
            // и ошибки уровня выполнения не будет. См. 26 строку.
            MyMethod();
        }
    }
}
