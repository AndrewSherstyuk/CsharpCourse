using System;

/// <summary>
/// Out
/// </summary>
namespace _012_Methods
{
    class Program
    {
        static void Main()
        {
            int argument;

            //out - позволяет передавать в метод непроинициализированные переменные.

            int result = Method(out argument);

            Console.WriteLine("{0}; {1};", argument, result);

            //Задержка.
            Console.ReadKey();
        }

        static int Method(out int x)
        {
            //Если закомментировать => ошибка уровня компиляции!
            x = 10;

            return 20;
        }
    }
}
