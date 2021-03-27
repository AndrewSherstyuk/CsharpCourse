using System;

/// <summary>
/// Статический консруктор
/// </summary>
namespace _005_Static
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.NotStaticMethod();

            Console.WriteLine(new string('-', 10));

            MyClass.Property = 10;
            Console.WriteLine(MyClass.Property);

            Console.WriteLine(new string('-', 10));

            MyClass.Method();
            MyClass.Method("argument");

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    ///  Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Закритое статическое поле
        /// </summary>
        private static int field;

        /// <summary>
        /// Статическое свойство
        /// </summary>
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }

        /// <summary>
        ///  Статический конструктор
        ///  Единственное назначение статических конструкторов 
        ///  присваивать исходные значения статическим переменным.
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("static constructor from MyClass work");
            field = 1;
        }

        /// <summary>
        /// Статические метод без аргументов
        /// </summary>
        public static void Method()
        {
            Console.WriteLine("static Method from MyClass, no argument");
        }

        /// <summary>
        ///  Статические метод с одним аргументом,
        ///  => cтатические методы могут быть перегружены
        /// </summary>
        /// <param name="argument"></param>
        public static void Method(string argument)
        {
            Console.WriteLine("static Method from MyClass, with argument {0}", argument);
        }

        /// <summary>
        /// Обычний, нестатический метод.
        /// </summary>
        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
