using System;

/// <summary>
/// Большие обекты размешаются в большой куче и сразу относятся ко второму поколению
/// </summary>
namespace _010_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            MyClass[] arrayMyClass = new MyClass[1000];

            try
            {
                for (int i = 0; i < arrayMyClass.Length; i++)
                {
                    MyClass myClass = new MyClass();
                }
            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }
    }

    class MyClass
    {
        Array array = new int[1000000000];

        public MyClass()
        {
            Console.WriteLine(this.GetHashCode());
        }
        ~MyClass()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
