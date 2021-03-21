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
            Console.WriteLine($"Square ABCD perimeter equals to: {Math.Round(square.perimeterCalc(), 2)}");

            Figure rectangle = new Figure(A, B, E, F);
            Console.WriteLine($"Rectangle ABEB perimeter equals to: {Math.Round(rectangle.perimeterCalc(), 2)}");

            Figure triangle1 = new Figure(A, B, F);
            Console.WriteLine($"Triable ABF perimeters equals to: {Math.Round(triangle1.perimeterCalc(), 2)}");

            Figure triangle2 = new Figure(A, B, E);
            Console.WriteLine($"Triable ABE perimeters equals to: {Math.Round(triangle2.perimeterCalc(), 2)}");

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
        Point point = new Point();

        private Point[] points;

        private string name;

        public double perimeter;        

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4) 
        {
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
        }

        private double lengthCalc(Point a, Point b)
        {     
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }

        public double perimeterCalc()
        {
            double p = lengthCalc(points[0], points[points.Length - 1]);
            
            for (int i = 0; i < points.Length - 1; i++)
            {                
                p = p + lengthCalc(points[i], points[i + 1]);                
            }

            perimeter = p;

            return perimeter;
        }

        
    }
}
