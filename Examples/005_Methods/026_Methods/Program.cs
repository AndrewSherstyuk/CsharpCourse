using System;

/// <summary>
/// Рекурсия
/// Нахождение наибольшего общего делителя (НОД) двух целых чисел
/// </summary>
namespace _026_Methods
{
    class Program
    {
        static void Main()
        {
            int x = 30;
            int y = 40;

            int result = Calculate(x, y);

            Console.WriteLine("a = {0}, b = {1}, НОД = {2};", x, y, result);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для нахождения наибольшего общего делителя (
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Calculate(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return Calculate(b, a % b);
            }
        }


    }
}
