using System;

/// <summary>
/// Методы расширения
/// Расширяющие методы не могут иметь опциональных параметров, 
/// но могут быть перегружены.
/// </summary>
namespace _013_Extension_Method
{
    class Program
    {
        static void Main()
        {
            string firstArgument = "first argument";
            string secondArgument = "second argument";
            string thirdArgument = "third argument";

            // Вызов метода, как статического.
            MyClass.ExtensionMethod(firstArgument);
            MyClass.ExtensionMethod(firstArgument, secondArgument);
            MyClass.ExtensionMethod(firstArgument, secondArgument, thirdArgument);

            Console.WriteLine(new string('-', 10));

            //Вызов метода, как расширяющего.
            firstArgument.ExtensionMethod();
            firstArgument.ExtensionMethod(secondArgument);
            firstArgument.ExtensionMethod(secondArgument, thirdArgument);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Статический класс MyClass, содержаший метод расширения
    /// </summary>
    static class MyClass
    {
        /// <summary>
        /// 1-я перегрузка расширяющего метода ExtensionMethod
        /// </summary>
        /// <param name="value">1-й параметр типа string</param>
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// 2-я перегрузка расширяющего метода ExtensionMethod
        /// </summary>
        /// <param name="value1">1-й параметр типа string</param>
        /// <param name="value2">2-й параметр типа string</param>
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + " " + value2);
        }

        /// <summary>
        /// 3-я перегрузка расширяющего метода ExtensionMethod
        /// </summary>
        /// <param name="value1">1-й параметр типа string</param>
        /// <param name="value2">2-й параметр типа string</param>
        /// <param name="value2">3-й параметр типа string</param>
        public static void ExtensionMethod(this string value1, string value2, string value3)
        {
            Console.WriteLine(value1 + " " + value2 + " " + value3);
        }
    }
}
