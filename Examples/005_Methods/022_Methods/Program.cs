using System;

/// <summary>
/// Во всех предыдущих примерах мы использовали постоянное число параметров. 
/// Но, используя ключевое слово params, мы можем передавать неопределенное количество параметров:
/// </summary>
namespace _022_Methods
{
    class Program
    {
        static void Main()
        {
            Method("Hello", "World", "test params", "1");

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для перебора передаваемого массива элементов
        /// </summary>
        /// <param name="array"></param>
        static void Method(params string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
