using System;

/// <summary>
/// Факториал натурального числа n определяется как произведение всех натуральных чисел от 1 до n включительно:
/// 5 ! = 1 * 2 * 3 * 4 * 5 = 120.
/// </summary>
namespace _027_Methods
{
    class Program
    {
        static void Main()
        {
            int i = 1;

            Console.WriteLine((i++ * i) + (++i));

            int x = 10;
            long y = 10;

            var res = x * y;

            Console.WriteLine(res.GetType());

            //Console.WriteLine(k);

            Console.ReadLine();

            int factorial1 = RecursionFactorial(5);
            int factorial2 = Factorial(5);

            Console.WriteLine("{0} = {1}", factorial1, factorial2);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для расчета факториала числа с рекурсией
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int RecursionFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        /// <summary>
        /// Метод для расчета факториала числа без рекурсии
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Factorial(int n)
        {
            int counter = n;
            int result = 1;

            while (counter>0)
            {
                result = result * counter--;
                //result *= counter--;
            }

            return result;
        }
    }
}
