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
            StringPainter.GetAndPaint();

            Console.ReadKey();
        }
    }

    public static class StringPainter
    {
        public static void GetAndPaint()
        {
            Console.WriteLine("Please enter the string you'd like to be shown in some color");
            string myString = Console.ReadLine();

            Console.WriteLine("\nUse the following numbers to select the color to print your string in");

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            foreach (var g in colors)
            {
                Console.WriteLine($"{g} = {(int)g}");
            }

            int c = int.Parse(Console.ReadLine());

            Console.ForegroundColor = colors[c];
            Console.WriteLine(myString + "\n");
            Console.ResetColor();

            Console.WriteLine("And here's your BONUS: your string printed in all possible combinations of Foreground and Background colors\n");

            for (int j = 0; j < colors.Length; j++)
            {
                Console.BackgroundColor = (ConsoleColor)colors[j];
                for (int i = 0; i < colors.Length; i++)
                {

                    Console.ForegroundColor = (ConsoleColor)colors[i];
                    Console.WriteLine(myString);

                }
            }
            Console.ResetColor();
        }
    }
}
