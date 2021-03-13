using System;

/// <summary>
///  Создание экземпляра класса по слабой ссылке.
/// </summary>
namespace _012_Classes
{
    class Program
    {
        static void Main()
        {
            //1-й способ вызова
           /* MyClass myClass = new MyClass();
            myClass.MyProperty = 10;
            myClass.Method();*/

            //2-й способ вызова
            new MyClass().MyProperty = 10;
            new MyClass().Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// MyClass
    /// </summary>
    class MyClass
    {
        public int MyProperty { get; set; }
        /// <summary>
        /// Method
        /// </summary>
        public void Method()
        {
            Console.WriteLine(MyProperty);
        }
    }
}
