using System;

/// <summary>
// Операции сравнения и проверки на равенство (<, <=, >, >=, ==, !=)
/// </summary>
namespace _026_Comparison
{
    class Program
    {
        static void Main()
        {
            byte value1 = 0;
            byte value2 = 1;
            
            bool result = false;

            //Меньше, чем (less than)
            result = value1 < value2;
            Console.WriteLine(result);

            //Больше чем (greater than)
            result = value1 > value2;
            Console.WriteLine(result);

            //Меньше или равно (less than or equal to)
            result = value1 <= value2;
            Console.WriteLine(result);

            //Больше или равно (greater than or equal to)
            result = value1 >= value2;
            Console.WriteLine(result);

            //Равно (equals)
            result = value1 == value2;
            Console.WriteLine(result);

            //Не равно (not equals)
            result = value1 != value2;
            Console.WriteLine(result);

            // Задержка.
            Console.ReadKey();
        }
    }
}
