using System;

/// <summary>
///  Тернарная операция.
/// Используя пять вариантов наборов карт 1) 6,7,8; 2) 7,8,9; 3) 6,9,10; 4) 6,9,8; 5) 7,6,10, сыграйте с компьютером. 
/// Введите с клавиатуры свой вариант и сравните с вариантом компьютера, который создайте, используя функцию генератора случайных чисел 
/// (три цифры от 6 до 10 включительно без повторения цифры в варианте). Если сумма цифр вашего варианта больше суммы цифр компьютера, вы выиграли.
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Пожалуйста, введите свой набор чисел");

            Console.WriteLine("введите 1- вое число");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 2- е число");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите 3- е число");
            int z = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int x1 = random.Next(6, 10);
            int y1 = random.Next(6, 10);
            int z1 = random.Next(6, 10);

            int sum = 0, sum1 = 0;

            sum = x + y + z;
            sum1 = x1 + y1 + z1;

            string result = sum > sum1 ? "Вы выиграли" : "Вы проиграли";

            Console.WriteLine(result);

            //Задержка
            Console.ReadKey();
        }
    }
}
