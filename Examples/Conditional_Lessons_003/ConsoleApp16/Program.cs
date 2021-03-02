using System;

/// <summary>
/// Конструкция switch/case
/// Используя конструкцию switch/case организовать ввод номера дня недели пользователем 
/// и в зависимости от дня недели вевести имя дня недели.
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            //Предложение пользователю номе дня недели.
            Console.WriteLine("Введите номер дня недели в интервале  [1-7] ");

            //Принимаем ввод от пользователя.
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
                case (1):
                    Console.WriteLine("Monday");
                    break;
                case (2):
                    Console.WriteLine("Tuesday");
                    break;
                case (3):
                    Console.WriteLine("Wednesday");
                    break;
                case (4):
                    Console.WriteLine("Thursday");
                    break;
                case (5):
                    Console.WriteLine("Friday");
                    break;
                case (6):
                    Console.WriteLine("Saturday");
                    break;
                case (7):
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Дня недели с таким номером не существует!");
                    break;
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
