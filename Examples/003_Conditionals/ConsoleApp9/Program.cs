using System;

/// <summary>
/// Тернарная операция.
/// Найти максимальное число из трех
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            //Предложение пользователю ввести первое число.
            Console.WriteLine("Введите первое число");
            //1-е число для сравнения
            int x = Convert.ToInt32(Console.ReadLine());

            //Предложение пользователю ввести второе число.
            Console.WriteLine("Введите второе число");
            //2-е число для сравнения
            int y = Convert.ToInt32(Console.ReadLine());

            //Предложение пользователю ввести третье число.
            Console.WriteLine("Введите третье число");
            //3-е число для сравнения
            int z = Convert.ToInt32(Console.ReadLine());

            //temp - переменная для хранения результата сравнения
            //изначально присваиваем значение 1-го числа
            int temp = x;

            //сравнение 1-го числа со 2-м, если 2>1, тогда temp присваевам значение 2-го числа
            temp = temp < y ? y : temp;

            //сравнение 2-го числа с 3-м, если 3>2, тогда temp присваевам значение 3-го числа
            temp = temp < z ? z : temp;

            //Оттеняем 
            Console.WriteLine(new string('*', 30));

            //Вывод результата сравнения
            Console.WriteLine("Максимальное число из {0}, {1}, {2} равно {3}", x, y, z, temp);

            //Задержка
            Console.ReadKey();
        }
    }
}
