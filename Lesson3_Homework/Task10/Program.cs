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

            Console.WriteLine("Please enter the salary. Please use comma as the decimal point");

            string salaryInput = Console.ReadLine();

            double bonus;

            double salary;

            bool ifConvertable = Double.TryParse(salaryInput, out salary);

            if (!ifConvertable)
            {
                Console.WriteLine("Please try another value: cannot parse {0}", salaryInput);
            }
            else
            {     
                Console.WriteLine("Please enter your seniourity");

                int seniority = Convert.ToInt32(Console.ReadLine());
               
                if (seniority < 5)
                {
                    bonus = salary * 0.1;
                    Console.WriteLine("Your bonus is {0}", bonus);
                }

                if (seniority >= 5 && seniority < 10)
                {
                    bonus = salary * 0.15;
                    Console.WriteLine("Your bonus is {0}", bonus);
                }

                if (seniority >= 10 && seniority < 15)
                {
                    bonus = salary * 0.25;
                    Console.WriteLine("Your bonus is {0}", bonus);
                }

                if (seniority >= 15 && seniority < 20)
                {
                    bonus = salary * 0.35;
                    Console.WriteLine("Your bonus is {0}", bonus);
                }

                if (seniority >= 20 && seniority < 25)
                {
                    bonus = salary * 0.45;
                    Console.WriteLine("Your bonus is {0}", bonus);
                }

                if (seniority >= 25 && seniority <= 50)
                {
                    bonus = salary * 0.5;
                    Console.WriteLine("Your bonus is {0}", bonus);
                }

                if (seniority <= 0 && seniority > 50)
                {
                    Console.WriteLine($"Weird seniority: {0}... Are you a human?", seniority);
                }                
            }

        goto Start;
        }
    }
}
