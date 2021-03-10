using System;

/// <summary>
/// Исключающего ИЛИ - ^ - [XOR]
/// </summary>
namespace _022_Exclusive_OR
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false;
            bool operand2 = false;
            bool result = false;

            // Таблица истинности для Исключающего ИЛИ - ^ - [XOR]

            // Если оба выражения операции Исключающего ИЛИ имеют одинакое значение -
            // все выражение имеет значение false, если разные - true 


            // false ^ false = false                   true ^ false = true
            // false ^ true = true                     true ^ true = false

            Console.WriteLine("Таблица истинности для Исключающего ИЛИ - ^ - [XOR]");
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // false ^ false = false   
            operand1 = false;                           // false          
            operand2 = false;                           // false
            result = operand1 ^ operand2;               // false

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // false ^ true = false   
            operand1 = false;                           // false          
            operand2 = true;                           // true
            result = operand1 ^ operand2;               // false

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // true ^ false = true
            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 ^ operand2;              // true

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // true ^ true = false
            operand1 = true;                           // true          
            operand2 = true;                          // true
            result = operand1 ^ operand2;              // false

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //Задержка
            Console.ReadKey();
        }
    }
}
