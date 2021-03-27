using System;

/// <summary>
/// Перегрузка операторов.
/// Синтаксис перегрузки оператора.
/// Point operator + (Point p1, Point p2) - метод, где:
/// Point   -  тип возвращаемого методом значения,
/// operator +  - имя метода,
/// (Point p1, Point p2) - аргументы метода.
/// </summary>
namespace _023_Operators
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 3);
            Point point2 = new Point(2, 4);

            Point point = point1 + point2;

            Console.WriteLine(point.ToString());

            Console.WriteLine(new string('-',10));

            Console.WriteLine(string.Format(@"Кординаты точки X = {0}, Y = {1}", 
                point.X, point.Y));

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс точка Point
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Кордината точки X
        /// </summary>
        public int X{ get; set; }

        /// <summary>
        ///  Кордината точки Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Конструктор класса Point
        /// </summary>
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Использовать ключевое слово operator, можно 
        /// только вместе с ключевым словом static 
        /// Перегрузка оператора +.
        /// </summary>
        public static Point operator + (Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.X, this.Y);
        }
    }
}
