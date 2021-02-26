using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter var 1");

            double var1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter var 2");

            double var2 = double.Parse(Console.ReadLine());

            Console.WriteLine(String.Format($"SUM of var1 and var 2 equals to           =>  {var1 + var2}"));
            Console.WriteLine(String.Format($"DIFFERENCE of var1 and var 2 equals to    =>  {var1 - var2}"));
            Console.WriteLine(String.Format($"PRODUCT or var1 and var 2 equals to       =>  {var1 * var2}"));
            Console.WriteLine(String.Format($"QUOTIENT of var1 and var 2 equals to      =>  {Math.Round((var1 / var2), 2)}"));

            Console.ReadKey();
        }
    }
}
