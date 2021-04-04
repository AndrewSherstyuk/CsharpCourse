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
            Calculator calc = new Calculator();

            calc.Launch();

            Console.ReadKey();
        }
    }

    class Calculator
    {
        double operand1 { get; set; }
        double operand2 { get; set; }
        char operation { get; set; }
        public void Launch()
        {
            Console.WriteLine("\nPlease enter operand1. Use comma as the decimal point");
            try
            {
                operand1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine("\nPlease enter operand2. Use comma as the decimal point");
            try
            {
                operand2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine("Please select the operation to apply to operand1 and operand2. \nType \"+\" for SUM, \"-\" for SUBSTRACTION, \"*\" for MULTIPLICATION and \"/\" for DIVISION");

            try
            {
                operation = Convert.ToChar(Console.ReadLine());
                if ((operation != '*' && operation != '/') && (operation != '+' && operation != '-'))
                {
                    throw new Exception("This is not a valid operation sign");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            switch (operation)
            {
                case ('+'):
                    {                        
                        Console.WriteLine($"Result is {operand1 + operand2}");
                        break;
                    }
                case ('-'):
                    {
                        Console.WriteLine($"Result is {operand1 - operand2}");
                        break;
                    }
                case ('*'):
                    {
                        Console.WriteLine($"Result is {operand1 * operand2}");
                        break;
                    }
                case ('/'):
                    {
                        try 
                        {                         
                            Console.WriteLine($"Result is {operand1 / operand2}");
                            break;
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                        break;
                    }
                default:
                    {
                        break; 
                    }
            }
        }
    }
}
