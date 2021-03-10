using System;

/// <summary>
///  Функция 
/// </summary>
namespace _003_Methods
{
    class Program
    {
        static void Main()
        {
            //В теле метода Main создаем строковую локальную переменную с именем functionResult
            // и присваиваем ей возвращаемое значение метода Function.
            string functionResult = Function();

            //Вывод значения переменной functionResult на экран
            Console.WriteLine(functionResult);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Функция для вывода приветствия
        /// </summary>
        /// <returns>Приветствия</returns>
        static string Function()
        {
            //Создаем переменную word
            string test = "Hello from Function!";
            //Вкачестве возвращаемого значения метода (Функция)
            //возращаем значение переменной 
            return test;
        }
    }
}
