using System;

/// <summary>
/// Обработка исключений
/// </summary>
namespace _010_Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                Method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // finally -не срабатывает в случае 
                // возникновения исключения 
                // StackOverflowException.
                while (true)
                    Console.WriteLine("Finally");
            }
        }

        /// <summary>
        /// Тут будет переполнение стека
        /// </summary>
        public static void Method()
        {
            int[] arr = new int[10];
            Console.WriteLine(arr);
            Method();
        }
    }
}
