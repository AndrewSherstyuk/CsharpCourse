using System;

/// <summary>
/// Вложенные классы.
/// Создаение экземпляра внешнего класса во внутреннем
/// </summary>
namespace _018_Nested
{
    class Program
    {
        static void Main()
        {
            MyClass.Nested nested = new MyClass.Nested();
            nested.Method(10);

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
        /// Закрытое поле field класса MyClass
        /// </summary>
        public int field = 0;

        public static Nested MyProperty { get; set; }

        /// <summary>
        /// Класс Nested - вложенный в MyClass
        /// </summary>
        public class Nested
        {
            //В методе вложенного класса создаем экземпляр
            //внешнего класса.
            
            /// <summary>
            /// Метод во вложенном классе
            /// </summary>
            /// <param name="a">аргумент вложеннго метода</param>
            public void Method(int a)
            {
                MyClass instance = new MyClass();
                instance.field = a;

                MyClass.MyProperty = this;

                Console.WriteLine(instance.field);
            }
        }
    }
}
