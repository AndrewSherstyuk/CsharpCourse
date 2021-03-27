using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape pyramide = new Pyramid(28, 12);
            Shape cylinder = new Cylinder(3, 7);
            Shape ball = new Ball(6);

            Shape[] figures = new Shape[3] { pyramide, cylinder, ball };

            Box box1 = new Box(200); // to put 1 figure in the box 
            Console.WriteLine("\nBOX 1");
            box1.Add(figures);

            Box box2 = new Box(500); // to put 2 figures in the box
            Console.WriteLine("\nBOX 2");
            box2.Add(figures);

            Box box3 = new Box(1000); // to put 3 figures in the box
            Console.WriteLine("\nBOX 3");
            box3.Add(figures);

            Box box4 = new Box(70); // to put 0 figures in the box
            Console.WriteLine("\nBOX 4");
            box4.Add(figures);

            Console.ReadKey();
        }
    }

    class Shape
    {
        protected double volume;
        protected const double pi = 3.14;

        public double Volume { get; set; }

        protected virtual double GetVolume() 
        {
            return Volume;
        }
    }

    class Pyramid : Shape
    { 
        protected double baseArea;
        protected double height;
        
        public Pyramid(double b, double h)
        {
            baseArea = b;
            height = h;
            Volume = GetVolume();
        }

        protected override double GetVolume()
        {
            volume = baseArea * height / 3;
            return Math.Round(volume, 2);
        }
    }

    class Cylinder : Shape
    {
        protected double radius;
        protected double height;        

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
            Volume = GetVolume();
        }

        protected override double GetVolume()
        {
            volume = pi * Math.Pow(radius, 2) * height;
            return Math.Round(volume, 2);
        }
    }

    class Ball : Shape
    {
        protected double radius;

        public Ball(double r)
        {
            radius = r;            
            Volume = GetVolume();
        }

        protected override double GetVolume()
        {
            volume = (4 / 3) * pi * Math.Pow(radius, 3);
            return Math.Round(volume, 2);
        }
    }

    class Box
    {
        private double drawerVolume;

        public Box(double d)
        {
            drawerVolume = d;
        }

        public bool Add(params Shape[] figures)
        {
            double initialDrawerVolume = drawerVolume;
            int n = 0;

            foreach (Shape figure in figures)
            {
                if (drawerVolume >= figure.Volume)
                {
                    drawerVolume -= Math.Round(figure.Volume, 2);
                    n++;
                }
                else
                {                    
                    break;
                }
            }

            if (n == figures.Length)
            {
                Console.WriteLine($"There's enough space in the box for {n} figures with total volume {initialDrawerVolume - drawerVolume}" +
                                $"\nAnd there's some additional space remaining in the box: {Math.Round(drawerVolume, 2)}");
                return true;
            }
            else if (n < figures.Length && n > 0)
            {
                Console.WriteLine($"{n} of the figures were put into the box, but there's not enough space for all {figures.Length} of them." +
                    $"\nGood news is that there's some space remaining in the box: {Math.Round(drawerVolume, 2)}");
                return true;
            }
            else
            {
                Console.WriteLine("Cannot put any of the figures into the box: each of the figures is larger than the box volume");
                return false;
            }
            
        }
        
    }
}
