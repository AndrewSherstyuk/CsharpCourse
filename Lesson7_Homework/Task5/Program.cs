using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(1, 1, 'A');
            Point B = new Point(1, 3, 'B');
            Point C = new Point(3, 3, 'C');
            Point D = new Point(3, 1, 'D');
            Point E = new Point(5, 3, 'E');
            Point F = new Point(5, 1, 'F');

            Figure square = new Figure(A, B, C, D);
            Console.WriteLine($"Square {square.Name} perimeter equals to: {Math.Round(square.PerimeterCalc(), 2)}");

            Figure rectangle = new Figure(A, B, E, F);
            Console.WriteLine($"Rectangle {rectangle.Name} perimeter equals to: {Math.Round(rectangle.PerimeterCalc(), 2)}");

            Figure triangle1 = new Figure(A, B, F);
            Console.WriteLine($"Triable {triangle1.Name} perimeters equals to: {Math.Round(triangle1.PerimeterCalc(), 2)}");

            Figure triangle2 = new Figure(A, B, E);
            Console.WriteLine($"Triable {triangle2.Name} perimeters equals to: {Math.Round(triangle2.PerimeterCalc(), 2)}");

            Console.ReadKey();
        }
    }

    class Point
    {
        private int x; 

        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }

        private int y;

        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }

        private char pointName;

        public char PointName
        {
            set
            {
                pointName = value;
            }
            get
            {
                return pointName;
            }
        }

        /// <summary>
        /// Constructs a point with parameter attributes
        /// </summary>
        /// <param name="x">X axis coordinate</param>
        /// <param name="y">Y axis coordinate</param>
        /// <param name="n">Name of the point</param>
        public Point(int x, int y, char n)
        {
            this.x = x;
            this.y = y;
            pointName = n;
        }

        public Point() { }
    }

    class Figure
    {
        private Point[] points;

        private string name;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        private double perimeter;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];

            name = String.Concat(point1.PointName, point2.PointName, point3.PointName);

            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4) : this(point1, point2, point3)
        {            
            Point[] p = new Point[4];
            points.CopyTo(p, 0);
            p[3] = point4;
            points = p;

            name = String.Concat(point1.PointName, point2.PointName, point3.PointName, point4.PointName);
        }

        private double LengthCalc(Point a, Point b)
        {     
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }

        public double PerimeterCalc()
        {
            double p = LengthCalc(points[0], points[points.Length - 1]);
            
            for (int i = 0; i < points.Length - 1; i++)
            {                
                p += LengthCalc(points[i], points[i + 1]);                
            }

            perimeter = p;

            return perimeter;
        }
    }
}
