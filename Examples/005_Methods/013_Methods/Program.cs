using System;

/// <summary>
/// Инкремент в методе
/// </summary>
namespace _013_Methods
{
    class Program
    {
        static void Main()
        {
            int argument = 10;
            argument = Increment(argument);

            Console.WriteLine(argument);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для инкрементации
        /// </summary>
        /// <param name="argument">аргумент для увелечения</param>
        /// <returns>увеличиныний на 1 аргумент</returns>
        static int Increment(int argument)
        {
            return ++argument;
        }
    }
}
