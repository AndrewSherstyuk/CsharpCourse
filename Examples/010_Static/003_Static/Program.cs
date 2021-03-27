using System;

namespace _003_Static
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            
            //myClass.StaticField = 10;
            //Console.WriteLine(myClass.StaticField);

            MyClass.StaticField = 10;
            Console.WriteLine(MyClass.StaticField);

            //Задаржка
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Статическое поле
        /// </summary>
        private static int staticField;

        /// <summary>
        /// Статическое свойсвто
        /// </summary>
        public static int StaticField 
        {
            get { return staticField; }
            set { staticField = value; }
        }
    }
}
