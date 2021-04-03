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
            Console.WriteLine("You need to enter 5 train numbers to save");

            int[] trainNumbers = new int[5];
            
            for (int i = 0; i < trainNumbers.Length; i++)
            {
                Console.WriteLine($"Please enter train {i + 1} number");
                trainNumbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Number for train {i + 1} has been successfully saved\n");
            }

            Train train1 = new Train("Kyiv", trainNumbers[0], "13:30");
            Train train2 = new Train("Kyiv", trainNumbers[1], "11:08");
            Train train3 = new Train("Kyiv", trainNumbers[2], "23:16");
            Train train4 = new Train("Kyiv", trainNumbers[3], "09:45");
            Train train5 = new Train("Kyiv", trainNumbers[4], "04:55");

            Train[] trains = new Train[] { train1, train2, train3, train4, train5 };

            Console.WriteLine("\nEnter the number of train you want to get information about");
            int myNumber = int.Parse(Console.ReadLine());
            bool ifNumberExists = false;

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == myNumber)
                {
                    trains[i].ShowInfo();
                    ifNumberExists = true;
                }
            }
            if(!ifNumberExists)
            {
                Console.WriteLine("There's no train with such a number");
            }

            Console.ReadKey();
        }
    }

    struct Train
    {
        public string Destination;
        public int TrainNumber;
        public string Time;

        public Train(string d, int n, string t)
        {
            Destination = d;
            TrainNumber = n;
            Time = t;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Train destination is {Destination} \nTrain number is {TrainNumber} \nTime is {Time}");
        }
    }
}
