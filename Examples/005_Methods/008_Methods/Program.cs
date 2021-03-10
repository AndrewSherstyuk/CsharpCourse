using System;

/// <summary>
/// return для метода, который не возвращает значения (void)
/// </summary>
namespace _008_Methods
{
    class Program
    {
        static void Main()
        {
            Exit(10);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация return 
        /// </summary>
        static void Exit(int x)
        {
            Console.WriteLine("Строка метода выполнится");

            //Если метод возвращает void, то для прирывания выполнения метода
            //используется оператор return
            if (true)
            {
                return;
            }
           

            Console.WriteLine("Строка метода не выполнится");
        }
    }
}
