using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAndDivide(header: "ddd", 2, 2, 3);
            SumAndDivide(22, new int[] { 2, 3, 4 });
            SumAndDivide(22, "", new int[] { 2, 3, 4 });
            SumAndDivide(22, "", 2, 3, 4);
            SumAndDivide(22, new int[] { 2, 3, 4 }, header: "");
        }

        static void SumAndDivide(int baseNumber, string header = "Hi", params int[] array)
        {
            var result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            result /= baseNumber;
            Console.WriteLine(header);
            Console.WriteLine("BaseNumber= {0}", baseNumber);
            Console.WriteLine("result = {0}", result);
        }
    }

        
        
}
