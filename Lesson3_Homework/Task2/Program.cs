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
        /* Противоречивые условия задачи, корректирую их таким образом:
         number > 7,      discount = 25%;
         3 < number <= 7, discount = 20%
         number == 3,     discount = 10%
         number < 3,      discount = 0%  */

        Start:

            Console.WriteLine("\nPlease enter the price of the product. Use comma as the decimal point: otherwise can't parse it.");

            string input = Console.ReadLine();

            double price;

            bool ifConvertable = Double.TryParse(input, out price);


            if (!ifConvertable)
            {
                Console.WriteLine("Please try another value: cannot parse {0}", input);
            }
            else
            {
                Console.WriteLine("Please enter the number of products you buy");

                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 7)
                {
                    Console.WriteLine($"\nYou buy {number} products \nYou got 25% discount \nSo total price is " +
                        $"{(price * (double)number) * 0.75} \nYou save { Math.Round(((price * (double)number) * 0.25), 2) } dollars");
                }
                else if (number > 3)
                {
                    Console.WriteLine($"\nYou buy {number} products \nYou got 20% discount \nSo total price is " +
                        $"{(price * (double)number) * 0.8} \nYou save { Math.Round(((price * (double)number) * 0.2), 2) } dollars");
                }
                else if (number == 3)
                {
                    Console.WriteLine($"\nYou buy {number} products \nYou got 10% discount \nSo total price is " +
                        $"{(price * (double)number) * 0.9} dollars \nYou save { Math.Round(((price * (double)number) * 0.1), 2) } dollars");
                }
                else
                {
                    Console.WriteLine($"\nYou buy {number} products \nYou got no discount \nSo total price is " +
                        $"{price * (double)number} \nBuy more products to save your money");
                }
            }           

            goto Start;
        }       
    }
}
