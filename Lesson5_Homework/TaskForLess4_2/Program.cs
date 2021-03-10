using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLess4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pinCode = "3145";

            for (int x = 0; x <= 2; x++)
            {
                Console.Write("Please enter your pin: ");

                string userPin = Console.ReadLine();

                if (userPin == pinCode)
                {
                    Console.WriteLine("Hello, the pin you entered is correct\n");
                    break;
                }

                if (x < 2)
                {
                    Console.WriteLine($"You entered incorrect pin, please try again. Attempts remained: {2 - x}\n");
                }
                else 
                {
                    Console.WriteLine("3 attemtps  to enter pin failed. Sorry, your card is blocked\n");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
