using System;

/// <summary>
/// Статический консруктор
/// </summary>
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
           //Статический конструктор вызывается в любом случае,
           //как при обращении к статическому члену, так и при 
           //создании экземпляра класса.

           //1-й вариант - вызивается только статический конструктор.
           //MyClass.StaticMethod();

           //2-й варинт - вызываются оба конструктора.
           MyClass myClass = new MyClass();
           myClass.Method();

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
        /// Конструктор
        /// </summary>
        public MyClass()
        {
            Console.WriteLine("constructor from MyClass work");
        }

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("static constructor from MyClass work");
        }

        /// <summary>
        /// Не статический метод
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Method");
        }

        /// <summary>
        /// Статический метод
        /// </summary>
        public static void StaticMethod()
        {
            Console.WriteLine("Static_Method");
        }
    }
}
