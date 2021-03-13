using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadKey();
        }
    }
}
