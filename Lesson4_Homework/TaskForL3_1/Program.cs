using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForL3_1
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("Please enter a value for x: ");

            double x = double.Parse(Console.ReadLine());

            double y;

            if (x <= -20)
            {
                y = 3 * Math.Pow(x, 3);

                y_Output(y.ToString());
            }
            else if (x > -20 && x <=30)
            {
                y = Math.Abs(x);

                y_Output(y.ToString());
            }
            else
            {
                y = 30;

                y_Output(y.ToString());
            }

            void y_Output(string z)
            {
                 Console.Write($"\'y\' equals to {z}\n\n");
            }

            goto Start;
        }
    }
}
