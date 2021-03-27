using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor7
{
    #region Conditions
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс Car (машина) который содержит в себе полями с
название, цвет, цена, const полем CompanyName. Создать два конструктора – по умолчанию и с
параметрами. Создать свойство доступа к полю цвет. Определить методы Input () - для ввода
данных о машине с консоли , Print () - для вывода данных о машине на консоль и ChangePrice
(double x) - для изменения цены на х%. Ввести данные о 3 авто. Уменьшить их цену на 10%, вывести
данные об авто. Ввести новый цвет и покрасить авто с цветом white в указанный цвет.*/
    #endregion

    class Program
    {       
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Car[] cars = new Car[3] { car1, car2, car3};

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"CAR {(i + 1).ToString()}");
                cars[i].Input();
                Console.WriteLine();
            }

            Console.WriteLine($"\nTHE LIST OF CARS AVAILABLE \n{new string ('=', 50)}");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"CAR {(i + 1).ToString()}");
                cars[i].Print();
                Console.WriteLine();
            }

            Console.WriteLine($"\nREDUCING THE PRICE BY 10% \n{new string('=', 50)}");
            
            for (int i = 0; i < cars.Length; i++)
            {                
                cars[i].ChangePrice(10);
            }

            Console.WriteLine($"\nNEW PRICES AFTER DISCOUNT WAS APPLIED \n{new string('=', 50)}");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"CAR {(i + 1).ToString()}");
                cars[i].Print();
                Console.WriteLine();
            }

            Console.WriteLine($"\nCHANGING THE COLOR OF THE WHITE CAR \n{new string('=', 50)}");

            Console.WriteLine("What color would you like to paint the white car to?");
            string color = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color == "White")
                {
                    cars[i].Color = color;
                }
            }

            Console.WriteLine($"\nNO WHITE CARS ANY MORE. CHECK THE NEW LIST BELOW \n{new string ('=', 50)}");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"CAR {(i + 1).ToString()}");
                cars[i].Print();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public const string COMPANYNAME = "INFOCAR";
        private string name;
        private string color;
        private decimal price;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 1000)
                {
                    price = value;
                }
            }
        }


        public Car() { }

        public Car(string name, string color, decimal price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            Console.Write("Please enter the car name: ");
            Name = Console.ReadLine();
            //Console.WriteLine();

            Console.Write("Please enter the car color: ");
            Color = Console.ReadLine();
            //Console.WriteLine();

            Console.Write("Please enter the car price: ");
            Price = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine($"The name of the car is {Name}");
            Console.WriteLine($"The color of the car is {Color}");
            Console.WriteLine($"The price of the car is {Price}");
        }

        public void ChangePrice(int x)
        {            
            Price -= Price * x / 100;
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }
    }
}
