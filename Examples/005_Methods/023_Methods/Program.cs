using System;

/// <summary>
/// Перегрузка метода Main
/// </summary>
namespace _023_Methods
{
    class Program
    {
        // Перегрузка. (Не является точкой входа)
        static string Main(string argument)
        {
            return "Hello " + argument + "!";
        }


        // Точка входа в программу.
        static int Main()
        {
            string @string = Main("World");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
