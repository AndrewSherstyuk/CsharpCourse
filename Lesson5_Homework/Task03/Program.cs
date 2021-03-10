using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.Write("Please enter the year of your birth: ");

            int myYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You're approximately {CalculateAge(myYear)} years old");

            goto Start;
        }


        /// <summary>
        /// Calculates the user's age
        /// </summary>
        /// <param name="year"></param>
        /// <returns>user's age</returns>
        static int CalculateAge(int year)
        {
            int age = (Convert.ToInt32(DateTime.Now.Year)) - year;

            return age;
        }
    }
}
