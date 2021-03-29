using System;

/// <summary>
/// Структура использование блока инициализатора
/// </summary>
namespace _009_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа
            Point point1 = new Point();
            point1.X = 10;
            point1.Y = 10;

            Console.WriteLine(point1.X);
            Console.WriteLine(point1.Y);

            Console.WriteLine(new string('-', 10));

            // Создание экземпляра структурного с 
            // блоком инициализатора
            Point point2 = new Point() { X = 20, Y = 20 };

            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);

            //Задержка
            Console.ReadKey();
        }
    }

    struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
