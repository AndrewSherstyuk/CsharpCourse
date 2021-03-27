using System;

/// <summary>
/// Сравнение 2-х Object с помощью метода Equals
/// </summary>
namespace _017_Object
{
    class Program
    {
        static void Main()
        {
            Object obj1 = new Object();
            Object obj2 = new Object();

            Console.WriteLine(obj1.Equals(obj2));

            obj1 = obj2;

            Console.WriteLine(obj1.Equals(obj2));

            // Задежка.
            Console.ReadKey();
        }
    }
}
