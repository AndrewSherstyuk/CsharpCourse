using System;

/// <summary>
/// Обработка исключений
/// </summary>
namespace _011_Exceptions
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
                // finally - сработает.
                Console.WriteLine("Finally");
            }

            // Задержка.
            Console.ReadKey();
        }

        public static void Method()
        {
            int[] arr = new int[100000000];
            Console.WriteLine(arr);
            Method();
        }
    }
}
