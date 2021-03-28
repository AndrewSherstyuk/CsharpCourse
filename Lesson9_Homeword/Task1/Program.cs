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
            IPrintable item1 = new Book() { Title = "Pride and Prejudice" };
            IPrintable item2 = new Magazine() { Title = "Vogue" };
            IPrintable item3 = new Book() { Title = "Hamlet" };
            IPrintable item4 = new Magazine() { Title = "Cosmopolitan" };
            IPrintable item5 = new Book() { Title = "Anna Karenina" };
            IPrintable item6 = new Magazine() { Title = "Playboy" };

            IPrintable[] items = new IPrintable[] { item1, item2, item3, item4, item5, item6 };

            Console.WriteLine($"'print()' method for all the items \n{new string('=', 45)}");
            
            foreach (IPrintable item in items)
            {
                item.print();
            }

            Console.WriteLine($"\n'printBooks()' method for all the items \n{new string('=', 45)}");
            Book book = new Book();
            book.printBooks(items);

            Console.WriteLine($"\n'printMagazines()' method for all the items \n{new string('=', 45)}");
            Magazine magazine = new Magazine();
            magazine.printMagazines(items);

            Console.ReadKey();
        }
    }

    interface IPrintable
    {
        void print();
        string Title { get; set; }
    }

    class Magazine : IPrintable
    {        
        public string Title { get; set; }

        public void print()
        {
            Console.WriteLine($"M A G A Z I N E : {Title}");
        }

        public void printMagazines(IPrintable[] printable)
        {
            foreach(IPrintable obj in printable)
            {
                if (obj is Magazine)
                {
                    Console.WriteLine($"MAGAZINE : {obj.Title}");
                }
            }
        }
    }

    class Book : IPrintable
    {   
        public string Title { get ; set; }

        public void print()
        {
            Console.WriteLine($"B O O K : {Title}");
        }

        public void printBooks(IPrintable[] printable)
        {
            foreach (IPrintable obj in printable)
            {
                if (obj is Book)
                {
                    Console.WriteLine($"BOOK : {obj.Title}");
                }
            }
        }
    }

}
