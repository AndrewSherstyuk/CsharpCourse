using System;


/// <summary>
/// Конструкция if c одной веткой 
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

            //Создание условной конструкции if, в условии которой проверяем условие, что x < y
            if (x < y)  // Если условие истинностное, выполняем тело условной конструкции.
            {
                Console.WriteLine("x < y"); // Ветвь 1
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
