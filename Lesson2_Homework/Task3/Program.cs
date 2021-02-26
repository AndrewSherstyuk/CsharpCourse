using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter triangle catheus 1 length");

            double catheus1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter triangle catheus 2 length");

            double catheus2 = double.Parse(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(catheus1, 2) + Math.Pow(catheus2, 2));

            Console.WriteLine("Hypotenuse length is equal to {0}", Math.Round(hypotenuse, 2));

            Console.ReadKey();
        }
    }
}
