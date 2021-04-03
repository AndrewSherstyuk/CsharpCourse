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
            Accountant acc = new Accountant();

            Positions[] positions = (Positions[])Positions.GetValues(typeof(Positions));

            foreach (Positions position in positions)
            {
                acc.AskForBonus(position, 200);
            }

            Console.ReadKey();
        }        
    }

    enum Positions
    {
        seniorSecretary = 240,
        middleSecretary = 221,
        juniorSecretary = 160,
        seniorAccountant = 278,
        middleAccountant = 264,
        projectManager = 151,
        productManager = 174,
        hrManager = 198,
        managingDirector = 305,
        cleaner = 108,
        cook = 98
    }

    class Accountant
    {
        public bool AskForBonus(Positions p, int hours)
        {
            if (hours <= (int)p)
            {
                Console.WriteLine($"{p} should get the bonus");
                return true;
            }
            else
            {
                Console.WriteLine($"{p} should NOT get the bonus");
                return false;
            }
                     
        }
    }
}
