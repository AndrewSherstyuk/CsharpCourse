using System;

namespace _026_Operators
{
    class Program
    {
        static void Main()
        {
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
        /// Перегруженный оператор ==.
        /// </summary>
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        /// <summary>
        /// Перегруженный оператор !=.
        /// </summary>
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        /// <summary>
        /// Переопределение метода Equals
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public override bool Equals(object o)
        {
            if (o is Point)
            {
                if (((Point)o).X == this.X && ((Point)o).Y == this.Y)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Переопределение GetHashCode() - 
        /// обязательна при переопределении Equals().
        /// </summary>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
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
