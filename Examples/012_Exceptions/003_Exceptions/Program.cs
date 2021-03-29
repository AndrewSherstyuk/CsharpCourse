using System;

/// <summary>
/// Обработка исключений
/// <summary>
namespace _003_Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new Exception("Мое Исключение");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(exception.Message);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
