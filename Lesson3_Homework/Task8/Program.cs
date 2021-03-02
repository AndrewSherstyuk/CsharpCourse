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
            Start:
            
            Console.WriteLine("\n\nPlease enter any integer within the following range: 0 - 100");

            int number = Convert.ToInt32(Console.ReadLine());

            char rangeID = 'Z';

            if (number >= 0 && number <= 14)
                rangeID = 'A';

            if (number >= 15 && number <= 35)
                rangeID = 'B';

            if (number >= 36 && number <= 50)
                rangeID = 'C';

            if (number >= 51 && number <= 100)
                rangeID = 'D';

            switch(rangeID)
            {
                case ('A'):
                    {
                        Console.WriteLine($"The number belongs to group {rangeID}, which means that it's equal to or larger than 0 and equal to or less than 14");
                        break;
                    }
                case ('B'):
                    {
                        Console.WriteLine($"The number belongs to group {rangeID}, which means that it's equal to or larger than 15 and equal to or less than 35");
                        break;
                    }
                case ('C'):
                    {
                        Console.WriteLine($"The number belongs to group {rangeID}, which means that it's equal to or larger than 36 and equal to or less than 50");
                        break;
                    }
                case ('D'):
                    {
                        Console.WriteLine($"The number belongs to group {rangeID}, which means that it's equal to or larger than 51 and equal to or less than 100");
                        break;
                    }
                case ('Z'):
                    {
                        Console.WriteLine($"The number doesn't belongs to or the groups, which means that it's either less than zero or larger than 100");
                        break;
                    }
            }

            goto Start;
        }
    }
}
