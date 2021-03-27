using System;

/// <summary>
/// Вложенные классы.
/// В языке C# любой класс в своей реализации может содержать объявление 
/// другого класса. Класс, который объявляется в пределах фигурных скобок 
/// другого класса, называется вложенным классом.
/// </summary>
namespace _016_Nested
{
    class Program
    {
        static void Main()
        {
            MyClass.Nested nested = new MyClass.Nested();
            
            nested.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Класс Nested - вложенный в MyClass
        /// </summary>
        public class Nested
        {
            /// <summary>
            /// Метод во вложенном классе
            /// </summary>
            public void Method()
            {
                Console.WriteLine("Method from Nested class");
            }
        }
    }
}
