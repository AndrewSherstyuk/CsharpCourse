using System;

/// <summary>
/// Методами-предикатами називаются методы которые возвращают логическое значение
/// (true или false)
/// </summary>
namespace _006_Methods
{
    class Program
    {
        static void Main()
        {
            bool argument1 = false;
            bool argument2 = false;

            //Переменная для хранения результата 
            bool result = Predicate(argument1, argument2);

            Console.WriteLine("{0} && {1} = {2}", argument1, argument2, result);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Конъюнкция 
        /// </summary>
        /// <param name="argument1">1-й аргумент</param>
        /// <param name="argument2">2-й аргумент</param>
        /// <returns>Результат конъюнкции</returns>
        static bool Predicate(bool argument1, bool argument2)
        {
            return argument1 && argument2;
        }
    }
}
