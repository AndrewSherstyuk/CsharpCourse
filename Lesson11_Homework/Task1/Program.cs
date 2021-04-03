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
            Notebook myNotebook = new Notebook("TravelMan", "Acer", 510.20m);

            myNotebook.NotebookInfo();

            Console.ReadKey();
        }
    }

    struct Notebook
    {
        string Model;
        string Brand;
        decimal Price;

        public Notebook(string m, string b, decimal p)
        {
            Model = m;
            Brand = b;
            Price = p;
        }

        public void NotebookInfo()
        {
            Console.WriteLine($"The Notebook model is {Model} \nThe Notebook Brand is {Brand} \nThe Notebook price is {Price}");
        }

    }

}
