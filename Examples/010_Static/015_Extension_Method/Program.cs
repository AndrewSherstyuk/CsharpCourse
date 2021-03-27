using System;

/// <summary>
/// Методы расширения
/// Рекурсия
/// </summary>
namespace _015_Extension_Method
{
    class Program
    {
        static void Main()
        {
            string @string = "Hellow from extension method";

            //Вызов метода, как расширяющего.
            @string.ExtensionMethod(5);

            Console.WriteLine(new string('-', 10));

            // Вызов метода, как статического.
            MyClass.ExtensionMethod(@string, 5);

            //Задержка
            Console.ReadKey();
        }
    }

    static class MyClass
    {
        public static void ExtensionMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine(value);
            Console.WriteLine(counter);

            if (counter != 0)
            {
                value.ExtensionMethod(counter);
            }
        }
    }

}
