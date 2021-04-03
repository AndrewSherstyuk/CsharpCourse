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
            MyClass myClass = new MyClass();
            myClass.Change = "not changed";

            MyStruct myStruct = new MyStruct();
            myStruct.Change = "not changed";

            Console.WriteLine($"MyClass.Change = {myClass.Change} \nMyStruct.Change = {myStruct.Change}");
            Console.WriteLine($"{new string ('=', 45)}");

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine($"MyClass.Change = {myClass.Change} \nMyStruct.Change = {myStruct.Change}");

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "changed";
        }
    }

    class MyClass
    {
        public string Change { get; set; }
    }

    struct MyStruct
    {
        public string Change { get; set; }
    }
}
