using System;

/// <summary>
///  Базовый класс Object.
///  Правило: Переопределяйте GetHashCode переопределяя Equals.
/// </summary>
namespace _019_Object
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(1, 2);
            Point point3 = new Point(3, 5);

            Console.WriteLine(point3.Equals(point1));
            Console.WriteLine(point1.Equals(point2));

            Console.WriteLine(point1.GetHashCode());
            Console.WriteLine(point2.GetHashCode());
            Console.WriteLine(point3.GetHashCode());

            Console.WriteLine(point1.ToString());
            Console.WriteLine(point2.ToString());
            Console.WriteLine(point3.ToString());

            Console.ReadKey();
        }
    }

    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        /// <summary>
        /// Конструктор класса Point
        /// </summary>
        public Point(int xValue, int yValue)
        {
            this.X = xValue;
            this.Y = yValue;
        }

        /// <summary>
        /// Переопределение метода Equals
        /// </summary>
        /// <param name="obj"></param>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            //DownCast
            Point p = (Point)obj;
            bool result = (X == p.X) && (Y == p.Y);
            return result;
        }

        /// <summary>
        /// Переопределение GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return X ^ Y;
        }

        /// <summary>
        /// Переопределение ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string information = string.Format(@"X: {0}, Y: {1}", X, Y);
            return information;

        }
    }
}
