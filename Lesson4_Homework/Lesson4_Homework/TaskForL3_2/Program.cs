using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForL3_2
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("Please enter the length of the square side: ");

            double squareSide = double.Parse(Console.ReadLine());

            Console.Write("Please enter the radius length: ");

            double circleRadius = double.Parse(Console.ReadLine());

            double squareSquare = Math.Round((Math.Pow(squareSide, 2)), 4);

            double circleSquare = Math.Round((Math.PI * Math.Pow(circleRadius, 2)), 4);

            string message = squareSquare > circleSquare ? "Square's square is larger than circle's square" : "Circle's square is larger or equal to square's square";

            Console.WriteLine($"\n{message}\n");

            goto Start;
        }
    }
}
