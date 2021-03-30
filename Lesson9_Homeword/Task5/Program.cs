using System;
using System.IO;
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
            XMLHandler xmlHandler = new XMLHandler();
            TXTHandler txtHandler = new TXTHandler();
            DOCHandler docHandler = new DOCHandler();

            Console.WriteLine("Please enter full path to your file, like C:\\mydir.old\\myfile.ext\n");

            string fullFileName = "@" + Console.ReadLine();
            string extension = Path.GetExtension(fullFileName);
            string fileName = Path.GetFileNameWithoutExtension(fullFileName);

            switch (extension)
            {
                case ".xml":
                    {
                        Console.WriteLine($"\nYour file {fileName} is an XML document because it has {extension} extention");
                        xmlHandler.Create();
                        xmlHandler.Open();
                        xmlHandler.Change();
                        xmlHandler.Save();
                        break;
                    }
                case ".txt":
                    {
                        Console.WriteLine($"\nYour file {fileName} is an TXT document because it has {extension} extention");
                        txtHandler.Create();
                        txtHandler.Open();
                        txtHandler.Change();
                        txtHandler.Save();
                        break;
                    }
                case ".doc":
                    {
                        Console.WriteLine($"\nYour file {fileName} is an DOC document because it has {extension} extention");
                        docHandler.Create();
                        docHandler.Open();
                        docHandler.Change();
                        docHandler.Save();
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"\nYour file {fileName} has unsupported format, please try another one.");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }

    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {  
        public override void Change()
        {
            Console.WriteLine($"Your XML document is changed");
        }

        public override void Create()
        {
            Console.WriteLine("The XML document is created");
        }

        public override void Open()
        {
            Console.WriteLine("The XML document is opened");
        }

        public override void Save()
        {
            Console.WriteLine("The XML document is saved");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("The TXT document is changed");
        }

        public override void Create()
        {
            Console.WriteLine("The TXT document is created");
        }

        public override void Open()
        {
            Console.WriteLine("The TXT document is opened");
        }

        public override void Save()
        {
            Console.WriteLine("The TXT document is saved");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("The DOC document is changed");
        }

        public override void Create()
        {
            Console.WriteLine("The DOC document is created");
        }

        public override void Open()
        {
            Console.WriteLine("The DOC document is opened");
        }

        public override void Save()
        {
            Console.WriteLine("The DOC document is saved");
        }
    }
}

