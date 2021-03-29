using System;

/// <summary>
/// Обработка исключений
/// Вложенный try - catch
/// </summary>
namespace _008_Exceptions
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
                Console.WriteLine("Обработка исключения 1:");
                userException.Method();

                try
                {
                    throw userException;
                }
                catch (UserException exception)
                {
                    Console.WriteLine("Обработка исключения 2:");
                    exception.Method();
                }
                finally
                {
                    Console.WriteLine("finally отрабатывает всегда!1");
                }
            }
            finally
            {
                Console.WriteLine("finally отрабатывает всегда!2");
            }

            Console.WriteLine("Дальше отрабатывает логика...");

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
