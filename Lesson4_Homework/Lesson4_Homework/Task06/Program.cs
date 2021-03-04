using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Petya's money amount");

            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter how much the ice-cream costs");

            int k = Convert.ToInt32(Console.ReadLine());

            int q = 0; // Number of ice-creams bought

            do
            {
                m = m - k;
                
                q++;
                
                Console.WriteLine($"Bought {q} ice-creams");

                if (m >= k)
                    continue;

                Console.WriteLine($"Petya bought {q} ice-creams. The following money amount remained: {m}");
            }
            while (m >= k);

            Console.ReadKey();
        }
    }
}
