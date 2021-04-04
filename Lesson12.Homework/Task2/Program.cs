using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Please enter the {i + 1} worker's name");
                string name = Console.ReadLine();

                Console.WriteLine($"Please enter the {i + 1} worker's surname");
                string surname = Console.ReadLine();

                Console.WriteLine($"Please enter the {i + 1} worker's position");
                string position = Console.ReadLine();

                Console.WriteLine($"Please enter the {i + 1} worker's year of birth");
                int yearOfBirth = 0;
                try
                {
                    yearOfBirth = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                if (yearOfBirth == 0)
                {
                    Console.WriteLine("Cannot save the worker: invalid year or birth");
                }
                else
                {
                    workers[i] = new Worker(name, surname, position, yearOfBirth);
                }
            }


            for (int j = 0; j < workers.Length; j++)
            {
                Console.WriteLine($"{workers[j].Name} {workers[j].Surname} {workers[j].Position} {workers[j].YearOfBirth}");
            }

            int age = 0;
            Console.WriteLine("Please enter maximum allowed worker's age");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number for worker's age");
            }

            for (int k = 0; k < workers.Length; k++)
            {
                if (age > 0 && DateTime.Now.Year - workers[k].YearOfBirth > age)
                {
                    Console.WriteLine($"{workers[k].Name} {workers[k].Surname} is older than {age}: this person is {DateTime.Now.Year - workers[k].YearOfBirth} years old");
                }
            }

            Console.ReadKey();
        }

        
    }
    struct Worker
    {
        public string Name;
        public string Surname;
        public string Position;
        public int YearOfBirth;

        public Worker(string n, string s, string p, int y)
        {
            Name = n;
            Surname = s;
            Position = p;
            YearOfBirth = y;
        }
    }
}
