using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            int y = 12;

            int z = 3;

            //Operation 1
            x = 10;
            y = 12;
            z = 3;
            x += y - x++ * z;
            Console.WriteLine("Operation 1: Int x equals to {0}", x);

            //Operation 2
            z = --x - y * 5;
            Console.WriteLine("Operation 2: Int z equals to {0}", z);

            //Operation 3
            y /= x + 5 % z;
            Console.WriteLine("Operation 3: Int y equals to {0}", y);

            //Operation 4
            z = x++ + y * 5;
            Console.WriteLine("Operation 4: Int z equals to {0}", z);

            //Operation 5
            x = y - x++ * z;
            Console.WriteLine("Operation 5: Int x equals to {0}", x);

            Console.ReadKey();
        }
    }
}
