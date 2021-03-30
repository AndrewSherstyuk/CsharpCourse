using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDocument doc1 = new MyDocument();

            doc1.Headline();
            doc1.DocumentContent();
            doc1.Footer();

            Console.ReadKey();
        }
    }

    abstract class Document
    {
        public abstract void Headline();
        public abstract void DocumentContent();
        public abstract void Footer();
    }

    class MyDocument : Document
    {
        public override void Headline()
        {
            Console.WriteLine("This is my document's HEADER");
        }

        public override void DocumentContent()
        {            
            {
                Console.WriteLine("This is my document's DOCUMENT CONTENT");
            }
        }

        public override void Footer()
        {
            Console.WriteLine("This is my document's FOOTER");
        }
    }
}
