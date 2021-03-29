using System;
using System.IO;

/// <summary>
/// Обработка исключений
/// Пользовательские исключения
/// Вложенные исключения
/// <summary>
namespace _006_Exceptions
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

                try
                {
                    FileStream fs = File.Open(@"C:\NonExistentFile.log", FileMode.OpenOrCreate);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            Console.WriteLine("cdc");

            // Delay.
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
