using System;

/// <summary>
/// Вложенные классы.
/// Внутренний класс видит все поля внешнего класса.
/// </summary>
namespace _017_Nested
{
    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.Method(10);

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
        /// Закрытое статическое поле field класса MyClass
        /// </summary>
        private static int field = 0;

        /// <summary>
        /// Класс Nested - вложенный в MyClass
        /// </summary>
        public class Nested
        {
            /// <summary>
            /// Метод во вложенном классе
            /// </summary>
            /// <param name="a">аргумент вложеннго метода</param>
            public void Method(int a)
            {
                //Присваеваем значение закрытому полю
                field = a;

                Console.WriteLine(field);
            }
        }
    }
}
