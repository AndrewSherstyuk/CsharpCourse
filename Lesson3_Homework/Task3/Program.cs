using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.WriteLine("\nPlease enter any integer from the following range: 0 - 59");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            bool isInRange = (userNumber >= 0) && (userNumber <= 59);

            if (!isInRange)
            {
                Console.WriteLine("We cannot process an out-of-range numbers, sorry for this");
            }
            else
            {
                Console.WriteLine("\nCongratulations! Your number belongs to the required range.");

                if (userNumber > 0 && userNumber < 15)
                {
                    Console.WriteLine("The number is in the 1st quarter");
                }
                else if (userNumber == 15)
                {
                    Console.WriteLine("The number is exactly between the 1st and the 2nd quarters");
                }
                else if (userNumber > 15 && userNumber < 30)
                {
                    Console.WriteLine("The number is in the 2nd quarter");
                }
                else if (userNumber == 30)
                {
                    Console.WriteLine("The number is exactly between the 2nd and the 3rd quarters");
                }
                else if (userNumber > 30 && userNumber < 45)
                {
                    Console.WriteLine("The number is in the 3rd quarter");
                }
                else if (userNumber == 45)
                {
                    Console.WriteLine("The number is exactly between the 3rd and the 4th quarters");
                }
                else if (userNumber > 45 && userNumber <= 59)
                {
                    Console.WriteLine("The number is in the 4th quarter");
                }
                else // userNumber == 0
                {
                    Console.WriteLine("Happy case! Your number equals to zero: it's between the 4th and the 1st quarters");
                }
            }

            goto Start;
        }
    }
}
