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
            Point p1 = new Point(2, 4, 5);
            Point p2 = new Point(5, 5, 7);

            Point pSum = p1 + p2;
            Console.WriteLine($"Sum of ({p1.ToString()}) and ({p2.ToString()}) is ({pSum.ToString()})\n");

            Point pDif = p1 - p2;
            Console.WriteLine($"Difference of ({p1.ToString()}) and ({p2.ToString()}) is ({pDif.ToString()})\n");

            Point pProd = p1 * p2;
            Console.WriteLine($"Product of ({p1.ToString()}) and ({p2.ToString()}) is ({pProd.ToString()})\n");

            Point pQuot = p1 / p1;
            Console.WriteLine($"Quotient of ({p1.ToString()}) and ({p2.ToString()}) is ({pQuot.ToString()})\n");

            Point pInitial = p1;
            Point pIncremented = ++p1;
            Console.WriteLine($"Point ({pInitial.ToString()}) incremented is ({pIncremented.ToString()})\n");

            Point pInitial1 = p2;
            Point pDecremented = --p2;
            Console.WriteLine($"Point ({pInitial1.ToString()}) decremented is ({pDecremented.ToString()})\n");

            bool equality = p1.Equals(p2);
            Console.WriteLine(equality + "\n");

            int hashCode = p1.GetHashCode();
            Console.WriteLine(hashCode + "\n");

            string p1ToString = p1.ToString();
            Console.WriteLine(p1ToString + "\n");

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс точка Point
    /// </summary>
    public class Point
    {
        
        public int X { get; set; }        
        public int Y { get; set; }
        public int Z { get; set; }

        
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
       
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
        }

        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
        }

        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.Y + 1, p1.Z + 1);
        }

        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.Y - 1, p1.Z - 1);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                if ((((Point)obj).X == this.X && ((Point)obj).Y == this.Y) && ((Point)obj).Y == this.Z)
                {
                    return true;
                }
            }           
            return false;            
        }
        
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }
    }
}