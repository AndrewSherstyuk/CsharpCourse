using System;

/// <summary>
/// Методы расширения
/// Аргумент расширения не может быть ни ref ни out, 
/// но аргументами расширения могут быть другие параметры метода
/// </summary>
namespace _014_Extension_Method
{
    class Program
    {
        static void Main()
        {
            int firstArgument = 10;
            int secondArgument = 20;
            int result;

            //Вызов метода, как расширяющего.
            firstArgument.ExtensionMethod(ref secondArgument, out result);

            Console.WriteLine(new string('-', 10));

            // Вызов метода, как статического.
            MyClass.ExtensionMethod(firstArgument, ref secondArgument, out result);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Статический класс MyClass, содержаший метод расширения
    /// </summary>
    static class MyClass
    {
        /// <summary>
        /// Метод расширения с ref и out параметрами
        /// </summary>
        /// <param name="summand1">Аргумент расширения</param>
        /// <param name="summand2">summand2 - ref параметр</param>
        /// <param name="sum">sum - out параметр</param>
        public static void ExtensionMethod(this int summand1, ref int summand2, out int sum)
        {
            sum = summand1 + summand2;

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);
        }
    }
}
