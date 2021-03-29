using System;

/// <summary>
/// Обработка исключений
/// <summary>
namespace _002_Exceptions
{
    class Program
    {
        static void Main()
        {
            Exception exception = new Exception("Мое Исключение");
            
            try
            {
                throw exception;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(ex.Message);
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
