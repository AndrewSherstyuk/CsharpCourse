using System;

/// <summary>
/// Возведение числа в степень 
/// </summary>
namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int n = 2;

            //Math - предоставляеты метод для работы с математическими функциями
            //Math.Pow(a, n) - возведит число в степень, 
            //тут a - число для которое возводится в степень, n - степень для возведения
            double result = Math.Pow(a, n);

            //Выводим значение переменной - result, на экран.
            Console.WriteLine(result);

            // Задержка.
            Console.ReadKey();
        }
    }
}
