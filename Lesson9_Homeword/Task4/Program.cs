using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class AbstractHandler
    {
        public abstract FileExtention { get; set;};
        
        public abstract void OpenDoc();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHander
{

}


}
