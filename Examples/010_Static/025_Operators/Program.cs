using System;

/// <summary>
/// Перегрузка операторов инкремента и дикримента.
/// </summary>
namespace _025_Operators
{
    class Program
    {
        static void Main()
        {
            Point point = new Point(0, 0);

            Console.WriteLine("a   = {0}", point);
            Console.WriteLine("a++ = {0}", point++);
            Console.WriteLine("a   = {0}", point);

            Console.WriteLine("a-- = {0}", point--);
            Console.WriteLine("a   = {0}", point);

            Console.WriteLine("++a = {0}", ++point);
            Console.WriteLine("a   = {0}", point);

            Console.WriteLine("--a = {0}", --point);
            Console.WriteLine("a   = {0}", point);

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
        public int X { get; set; }

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
        /// Перегруженный оператор ++.
        /// </summary>
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.X + 1);
        }

        /// <summary>
        /// Перегруженный оператор --.
        /// </summary>
        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.X - 1);
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
