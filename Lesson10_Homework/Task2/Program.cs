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
            DegreesConverter.Launcher();
        }
    }

    public static class DegreesConverter
    {
        public static void Launcher()
        {
            Console.WriteLine("WELCOME TO DEGREES CONVERTER! \nPress 'F' to convert from Fahrenheit to Celsius " +
                "\nPress 'C' to convert Celsius to Fahrenheit \nPress any other button to exit");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case string c when c == "F" || c == "f":
                    {
                        FtC();
                        break;
                    }
                case string c when c == "C" || c == "c":
                    {
                        CtF();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private static void FtC()
        {
            Console.Write("\nPlease enter number of Fahrenheit degrees to convert to Celsius. Use comma as the decimal point: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = Math.Round((f - 32) / 1.8, 2);
            Console.WriteLine($"{f} degrees Fahrenheit equals to {c} degrees Celsius\n");

            Launcher();
        }

        private static void CtF()
        {
            Console.Write("\nPlease enter number of Fahrenheit degrees to convert to Celsius. Use comma as the decimal point: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = Math.Round((c * 1.8 + 32), 2);
            Console.WriteLine($"{c} degrees Celsius equals to {f} degrees Fahrenheit\n");

            Launcher();
        }
    }
}
