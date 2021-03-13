using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForL5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter amount of meters, use comma as the decimal point: ");

            double m = double.Parse(Console.ReadLine());

            Console.Write("\n");

            metersConverter(m, out double cm);

            metersConverter(m, out double cm1, out double mm);

            metersConverter(m, out double cm2, out double mm1, out double km);

            Console.ReadKey();
        }

        static void metersConverter(double m, out double cm)
        {
            cm = m * 100;

            Console.WriteLine($"{m} equals to {cm} centimeters");
        }

        static void metersConverter(double m, out double cm, out double mm)
        {
            cm = m * 100;
            mm = m * 1000;

            Console.WriteLine($"{m} meters equals to {cm} centimeters and {mm} millimeters");
        }

        static void metersConverter(double m, out double cm, out double mm, out double km)
        {
            cm = m * 100;
            mm = m * 1000;
            km = m * 0.001;

            Console.WriteLine($"{m} meters equals to {cm} centimeters, {mm} millimeters and {km} kilometers");
        }
    }
}
