using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {            
            int total = 700;

            Start:

            WriteIn($"Client's debt is {total}. Please enter the payment amount: ");

            int payment = int.Parse(Console.ReadLine());

            LoanStatus(ref total, payment);

            if (total > 0)
            {
                goto Start;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Substracts payment amount from remaining amount of loan and prints 3 options of status after payment
        /// </summary>
        /// <param name="t">Total loan amount</param>
        /// <param name="p">Payment amount</param>
        static void LoanStatus(ref int t, int p)
        {
            t -= p;

            if (t > 0)
            {
                WriteIn ($"Current debt amount is {t}\n\n", "yellow");
            }
            else if (t == 0)
            {
                WriteIn("The load is fully paid, congratulations to the client!\n\n", "green");
            }
            else
            {
                WriteIn($"Overpayment amount is {Math.Abs(t)}, give it back to the client!!!\n\n", "red");
            }
        }

        /// <summary>
        /// Displays a string in selected color
        /// </summary>
        /// <param name="color">Optional: Can be red, yellow and green. Default is white</param>
        /// <param name="myString"></param>
        static void WriteIn(string myString, string color = "white")
        {
            switch (color)
            {
                case "red":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(myString);
                        Console.ResetColor();
                        break;
                    }
                case "green":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(myString);
                        Console.ResetColor();
                        break;
                    }
                case "yellow":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(myString);
                        Console.ResetColor();
                        break;
                    }
                default:
                    {
                        Console.WriteLine(myString);
                        break;
                    }
            }
        }
    }
}
