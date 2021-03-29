using System;

/// <summary>
/// Большие обекты размешаются в большой куче и сразу относятся ко второму поколению
/// </summary>
namespace _009_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            //Обект array - Будет размешен в большой куче 
            int[] array = new int[100000000];

            Console.WriteLine(GC.GetGeneration(array));

            //Будет размешен в малой куче, по факту псевдообъект,
            //а внутренний масив будет размешен на большой куче
            MyClass myClass = new MyClass();
            Console.WriteLine(GC.GetGeneration(myClass.array));

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public Array array = new int[100000000];

        public MyClass()
        {
            Console.WriteLine(this.GetHashCode());
        }
        ~ MyClass()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
