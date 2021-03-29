using System;

/// <summary>
/// Обработка исключений
/// Блок finally, после блока catch будет выполняться блок finally.
/// <summary>
namespace _007_Exceptions
{
    class Program
    {
        static void Main()
        {
            int a = 1, n = 2;

            try
            {
                Console.WriteLine("Попытка деления на ноль.");
                Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
            }
            catch (Exception e)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally отрабатывает всегда!");
            }

            Console.WriteLine("Дальше отрабатывает логика...");

            // Задержка
            Console.ReadKey();
        }
    }
}
