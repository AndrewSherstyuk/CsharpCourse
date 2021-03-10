using System;

/// <summary>
/// Для работы с датами и временем в .NET предназначена структура DateTime. 
/// </summary>
namespace _029_DateTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);

             // Задержка.
            Console.ReadKey();

        }
    }
}
