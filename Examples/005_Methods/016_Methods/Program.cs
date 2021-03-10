using System;

/// <summary>
/// Исправленная версия предыдущего примера
/// </summary>
namespace _016_Methods
{
    class Program
    {
        static void Main()
        {
            //1-й аргумент
            Console.WriteLine("Введите 1-e число.");
            int argument1 = Convert.ToInt32(Console.ReadLine());

            //2-й аргумент
            Console.WriteLine("Введите 2-e число.");
            int argument2 = Convert.ToInt32(Console.ReadLine());

            //Переменная для хранения результата
            int result;

            //Вызов метода Sum
            Sum(ref argument1, ref argument2, out result);

            // Логическая ошибка
            Console.WriteLine("{0} + {1} = {2}", argument1, argument2, result);

            //Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для сумирования 2-х аргументов
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="sum"></param>
        static void Sum(ref int x, ref int y, out int sum)
        {
            sum = x + y;
        }
    }
}
