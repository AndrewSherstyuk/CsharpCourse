using System;
using System.Threading;

/// <summary>
/// Деструктор - обработка исключений
/// </summary>
namespace _005_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            
        }
    }

    class MyClass
    {
        /// <summary>
        /// Деструктор
        /// </summary>
        ~MyClass()
        {
            //Обработка исключений
            try
            {
                throw new Exception("Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Destructor from MyClass");
            }
        }
    }
}
