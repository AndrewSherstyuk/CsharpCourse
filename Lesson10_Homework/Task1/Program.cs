using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.SelectOperation();
        }
    }

    static class Calculator
    {
        public static void SelectOperation()
        {
            Console.WriteLine("WELCOME TO CALCULATOR! PRESS 'P' TO PROCEED OR ANY OTHER KEY TO EXIT");
            string c = Console.ReadLine();

            if (c == "P" || c == "p")
            {
                UserInteractor();
            }
        }
        
        public static void UserInteractor()
        {
            Console.WriteLine("\nPlease enter operand1. Use comma as the decimal point");

            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter operand2. Use comma as the decimal point");

            double operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select the operation to apply to operand1 and operand2. " +
                "\nType \"+\" for SUM, \"-\" for SUBSTRACTION, \"*\" for MULTIPLICATION and \"/\" for DIVISION");

            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case ('+'):
                    {
                        Console.WriteLine($"Result is {operand1 + operand2}\n");
                        break;
                    }
                case ('-'):
                    {
                        Console.WriteLine($"Result is {operand1 - operand2}\n");
                        break;
                    }
                case ('*'):
                    {
                        Console.WriteLine($"Result is {operand1 * operand2}\n");
                        break;
                    }
                case ('/'):
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Result is {operand1 / operand2}\n");
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Impossible operation, try another one!!!\n");
                        break;
                    }
            }
            
            SelectOperation();
        }
    }
}
