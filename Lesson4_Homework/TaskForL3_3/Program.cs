using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForL3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("\nPlease enter the angle value: ");

            int angle = int.Parse(Console.ReadLine());

            switch (angle)
            {
                case int n when (n > 0 && n < 90):
                    {
                        Console.WriteLine("The angle is acute");
                        break;
                    }
                case int n when (n == 90):
                    {
                        Console.WriteLine("The angle is right");
                        break;
                    }
                case int n when (n > 90 && n < 180):
                    {
                        Console.WriteLine($"The angle is obtuse");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Can't specify the angle type");
                        break;
                    }
            }

            goto Start;
        }
    }
}
