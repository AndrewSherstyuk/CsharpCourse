using System;

/// <summary>
/// Методы расширения
/// Аргумент расширения всегда должен быть 
/// только один и стоять первым в списке аргументов.
/// </summary>
namespace _012_Extension_Method
{
    class Program
    {
        static void Main()
        {
            string @string = "Hellow from extension method";
            string @secondArgument = "Second argument";

            // Вызов метода, как статического.
            MyClass.ExtensionMethod(@string, @secondArgument);

            Console.WriteLine(new string('-', 10));

            // Вызов метода, как расширяющего.
            @string.ExtensionMethod(@secondArgument);

            @secondArgument.ExtensionMethod(@string);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Статический класс MyClass, содержаший метод расширения
    /// </summary>
    public static class MyClass
    {
        /// <summary>
        /// Метод расширения
        /// Принимает 2 аргумента, аргумент расширения может быть только одни
        /// и стоять 1-вым в списке аргументов
        /// </summary>
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }
}
