using System;

/// <summary>
/// Convert - представляет еще один способ для преобразования значений. 
/// </summary>
namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            int @int = 10;
            Console.WriteLine(@int);

            string @string = Convert.ToString(@int);
            Console.WriteLine(@string);

            int convertFromString = Convert.ToInt32(@string);
            Console.WriteLine(convertFromString);

            int parseFromString = int.Parse(@string);
            Console.WriteLine(parseFromString);

            // Задержка.
            Console.ReadKey();
        }
    }
}
