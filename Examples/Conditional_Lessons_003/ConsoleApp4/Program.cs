using System;

/// <summary>
/// Тернарная операция
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            //Создание переменной x;
            int x = 100;

            //Создание переменной y;
            int y = 20;

            //Создание переменной z;
            int z = 30;

            //выбор максимального значения между переменными x и y
            //изначально значения операция z = y, а потом result = y 
            int result = x > y ? z = x : z = y;

            Console.WriteLine(z);

            //Задержка
            Console.ReadKey();
        }
    }
}
