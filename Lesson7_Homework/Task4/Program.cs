using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter side 1 of the triangle: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("\nPlease enter side 2 of the trialgle: ");

            double b = double.Parse(Console.ReadLine());

            Console.Write("\nPlease enter side 3 of the triangle: ");

            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Triangle t = new Triangle(a, b, c);            

            t.ShowPerimeterAndArea();

            Console.ReadKey();
        }
    }

    class Triangle
    {
        private double side1;

        private double side2;

        private double side3;

        public double tArea;

        public double tPerimeter; 

        public double Side1
        {
            set
            {
                side1 = value;
            }
            get
            {
                return side1;
            }
        }

        public double Side2
        {
            set
            {
                side2 = value;
            }
            get
            {
                return side2;
            }
        }

        public double Side3
        {
            set
            {
                side3 = value;
            }
            get
            {
                return side3;
            }
        }
       
        public Triangle(double a, double b, double c)
        {
            Side1 = a;

            Side2 = b;

            Side3 = c;
        }

        /// <summary>
        /// Calculates perimeter of the triangle
        /// </summary>
        /// <returns>Triangle's perimeter</returns>
        private double CalcPerimeter()
        {
            tPerimeter = side1 + side2 + side3;

            return tPerimeter;
        }

        /// <summary>
        /// Calculates area of a triangle
        /// </summary>
        /// <returns>Triangle's area</returns>
        private double CalcArea()
        {
            double hP = CalcPerimeter() / 2;
            
            tArea = Math.Sqrt(hP * (hP + side1) * (hP + side2) * (hP + side3));

            return tArea;
        }

        /// <summary>
        /// Shows Triangle's perimeter and area
        /// </summary>
        public void ShowPerimeterAndArea()
        {
            Console.WriteLine("Perimeter of the triangle is: \t{0} \nArea of the triangle is: \t{1}", CalcPerimeter(), Math.Round(CalcArea(), 2));
        }

}
}
