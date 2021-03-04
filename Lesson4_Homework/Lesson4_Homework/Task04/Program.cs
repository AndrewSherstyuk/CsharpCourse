using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the deposit amount");

            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the interest rate");

            double percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the term of deposit (number of years)");            

            int years = Convert.ToInt32(Console.ReadLine());

            int yearCounter = 0;

            Console.WriteLine("\n");

            do
            {
                yearCounter++;
                sum = sum + (sum / 100) * percent;
                Console.WriteLine($"After year {yearCounter} you get {sum}");                
                years--;
            }
            while (years >= 1);

            Console.WriteLine($"\nGood news: The final sum you get is {sum} \nBad news: You have to wait for {yearCounter} years");

            Console.ReadKey();
        }
    }
}
