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
            Console.WriteLine("Please enter a string you want to count symbols in");
            string s = Console.ReadLine();

            Console.WriteLine("Please enter a serial number of symbol from which you want to count");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number of symbols in your string is {StringExtension.StrCount(s, i)} if starting count from symbol {i}");

            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static int StrCount(string s, int i)
        {
            char[] c = s.ToCharArray();
            return c.Length - i + 1;
        }
    }
}
