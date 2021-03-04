using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Start: 
            Console.WriteLine("\nPlease enter operand1. Use comma as the decimal point");

            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter operand2. Use comma as the decimal point");

            double operand2 = Convert.ToDouble(Console.ReadLine());

        SelectOperation:

            Console.WriteLine("Please select the operation to apply to operand1 and operand2. \nType \"+\" for SUM, \"-\" for SUBSTRACTION, \"*\" for MULTIPLICATION and \"/\" for DIVISION");

            char operation = Convert.ToChar(Console.ReadLine());

            if (operation != '0')
            {
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
                            if (operand2 == 0)
                            {
                                Console.WriteLine("Cannot divide by zero");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Result is {operand1 / operand2}");
                                break;
                            }
                        }
                    default:
                        {
                            goto SelectOperation;
                        }
                }

                goto Start;
            }

            else { }   
        }
    }
}