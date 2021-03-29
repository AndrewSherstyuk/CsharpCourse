using System;

/// <summary>
/// GC.WaitForPendingFinalizers - в свойтвах проекта необходимо включить оптимизацию
/// </summary>
namespace _008_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            GC.Collect();

            //приостновка первичного потока пока не удалим весь мусор
            GC.WaitForPendingFinalizers();

            Console.WriteLine();

            for (int i = 0; i < 80; i++)
            {
                Console.Write("+");
            }

            //Задержка 
            Console.ReadLine();
        }
    }

    class MyClass
    {
        ~MyClass()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
        }
    }
}
