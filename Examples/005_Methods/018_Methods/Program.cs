using System;

/// <summary>
/// Именованный аргумент – это такой аргумент, 
/// который при вызове метода содержит имя параметра, 
/// которому передается значение этого аргумента.
/// </summary>
namespace _018_Methods
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;

            //1-й вариант вызова метода 
            int result1 = Multiplication(x, y);

            Console.WriteLine("{0} * {1} = {2}", x, y, result1);

            //2-й вариант вызова метода
            int result2 = Multiplication(argument2: x, argument1: y);

            Console.WriteLine("{0} * {1} = {2}", x, y, result2);

            Console.ReadKey();
        }

        static int Multiplication(int argument1, int argument2)
        {
            Console.WriteLine(argument1);
            Console.WriteLine(argument2);

            return argument1 * argument2; 
        }
    }
}
