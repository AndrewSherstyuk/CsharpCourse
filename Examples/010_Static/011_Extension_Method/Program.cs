using System;
using System.Linq;

/// <summary>
/// Методы расширения 
/// Методы расширения (extension methods) позволяют добавлять 
/// новые методы в уже существующие типы без создания нового 
/// производного класса. 
/// Расширяющие методы могут быть только статическими 
/// и создаваться только в статических классах.
/// </summary>
namespace _011_Extension_Method
{
    class Program
    {
        static void Main()
        {
            string @string = "Hellow from extension method";

            // Вызов метода, как статического.
            MyClass.ExtensionMethod(@string);

            Console.WriteLine(new string('-', 10));

            // Вызов метода, как расширяющего.
            @string.ExtensionMethod();

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
        /// this - перед типом аргумента -  сообщает компилятору, 
        /// что данный метод является расширяющим 
        /// </summary>
        /// <param name="value"></param>
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }
}
