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
            Kitty kitty = new Kitty();

            kitty.Name = "Murzik";

            kitty.Age = 1;

            kitty.EyesColor = "green";

            kitty.WoolColor = "gray";

            kitty.PrintMeow(8);

            Console.ReadKey();
        }
    }

    class Kitty
    {
        private string name;

        private int age;

        private string woolColor;

        private string eyesColor;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        public string WoolColor
        {
            set
            {
                woolColor = value;
            }
            get
            {
                return woolColor;
            }
        }

        public string EyesColor
        {
            set
            {
                eyesColor = value;
            }
            get
            {
                return eyesColor;
            }
        }

        public void PrintMeow(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Meow ");
            }
        }
    }
}
