using System;

/// <summary>
/// Проверка делимости одного числа на другое
/// Вводятся два целых числа. Проверить делится ли первое на второе. 
/// Вывести на экран сообщение об этом, а также остаток (если он есть) и целую часть (в любом случае).
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число");

            string firstNumber = Console.ReadLine();
            int x = Convert.ToInt32(firstNumber);

            Console.WriteLine("Введите первое число");

            string secondNumber = Console.ReadLine();
            int y = Convert.ToInt32(secondNumber);

            //Проверка деления на 0
            if (y == 0)
            {
                //Вывод результата о запрете деления
                Console.WriteLine(string.Format(@"{0} не делится {1}, деление на 0 запрещено!", x, y));
            }
            else //Если нет ограничений, то выполняем операцию деления
            {
                //Целая часть
                int integerPart = x / y;

                //Остаток от деления
                double fractionalPart = (double)(x % y) / y;

                //Вывод результата
                Console.WriteLine(string.Format(@"{0} делится {1}, целая часть = {2}, остаток от деления = {3}", x, y, integerPart, fractionalPart));
            }

            //Задержка
            Console.ReadKey();

        }
    }
}
