using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the priсe");

            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the discount");

            double discount = double.Parse(Console.ReadLine());

            double discountPrice = Math.Round(price / 100 * discount, 2);

            Console.WriteLine(@"Congratulations! This product costs {0} dollars ONLY for you and ONLY today", (price - discountPrice));

            Console.ReadKey();
        }
    }
}
