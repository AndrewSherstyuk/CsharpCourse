using System;

/// <summary>
/// Обработка исключений
/// </summary>
namespace _012_Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                //finally - не срабатывает если 
                //не завершается работа блока catch.
                //throw new Exception();

                // или так ...

                while (true)
                    Console.WriteLine("Catch");
            }
            finally
            {
                // finally - не сработает!
                while (true)
                    Console.WriteLine("Finally");
            }

            // Задержка
            Console.ReadKey();
        }
    }
}
