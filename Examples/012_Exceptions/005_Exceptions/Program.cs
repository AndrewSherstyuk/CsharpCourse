using System;

/// <summary>
/// Обработка исключений
/// Пользовательские исключения
/// <summary>
namespace _005_Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException();
            }
            catch (UserException userException)
            {
                Console.WriteLine("Обработка исключения.");
                userException.Method();
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Для создания пользовательского исключения, 
    /// требуется наследование от System.Exception.
    /// </summary>
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Мое Исключение!");
        }
    }
}
