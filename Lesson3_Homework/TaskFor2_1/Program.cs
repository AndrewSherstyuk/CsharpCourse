using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            int b = 20;

            byte prod = (byte)(a * b);

            byte quot = (byte)(a / b);

            byte summ = (byte)(a + b);

            byte diff = (byte)(a - b);

            byte rmdr = (byte)(a % b);

            Console.WriteLine($"The product equals to \t\t {prod} \nThe quotient equals to \t\t {quot}" +
                $"\nThe sum equals to \t\t {summ} \nThe difference equals to \t {diff} \nThe remainder equals to \t {rmdr}");

            Console.ReadKey();
        }
    }
}
