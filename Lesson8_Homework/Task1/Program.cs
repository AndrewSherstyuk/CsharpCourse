using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(25, "circle", 7, "brown", "Sharik");

            dog.ShowInfo();

            Console.ReadKey();
        }
    }

    class Tail
    {
        protected int tailLength;
        protected string tailShape;

        public int TailLength
        {
            get
            {
                return tailLength;
            }
            set
            {
                tailLength = value;
            }
        }

        public string TailShape
        {
            get
            {
                return tailShape;
            }
            set
            {
                tailShape = value;
            }
        }

        public Tail(int tailLength, string tailShape)
        {
            this.tailLength = tailLength;
            this.tailShape = tailShape;
        }
    }

    class Animal : Tail
    {
        protected int age;
        protected string color;
        public Animal(int tailLength, string tailShape, int age, string color) : base (tailLength, tailShape)
        {
            this.age = age;
            this.color = color;
        }
    }

    class Dog : Animal
    {
        private string name;

        public Dog(int tailLength, string tailShape, int age, string color, string name) : base(tailLength, tailShape, age, color)
        {
            this.name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"The dog's name is {name} \nThe dog's age is {age} \nThe dog's color is {color} \n" +
                $"The dog's tail length is {tailLength} \nThe dog's tail shape is {tailShape}");
        }
    }

}
