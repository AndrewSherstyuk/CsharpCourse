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
            Console.WriteLine("Please enter the value for variable 'a'");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine($"That's correct, {a} is larger than 10");
            } else 
            {
                Console.WriteLine($"That's no correct, {a} is equal or less than 10");
            }

            Console.ReadKey();
        }
    }
}
