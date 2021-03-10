using System;

/// <summary>
/// Конъюнкция - это логическая операция, принятая в формализованных 
/// языках для образования сложных высказываний из простых и по смыслу 
/// эквивалентная соединительному союзу «и» в естественном языке.
/// </summary>
namespace _020_Conjunction
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false;
            bool operand2 = false;
            bool result = false;

            // Таблица истинности для Конъюнкции (И) - && - [AND]
            // Если хоть одно из выражений операции операции конъюнкции имеет значение false -
            // все выражение имеет значение false, иначе - true
            // false && false = false                  true && false = false
            // false && true = false                   true && true = true

            Console.WriteLine("Таблица истинности для Конъюнкции (И) - && - [AND]");
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //false && false = false  
            operand1 = false;                           // false          
            operand2 = false;                           // false
            result = operand1 && operand2;              // false

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // false && true = false  
            operand1 = false;                           // false          
            operand2 = true;                            // true
            result = operand1 && operand2;              // false

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //true && false = false
            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 && operand2;             // false
            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //true && true = true
            operand1 = true;                           // true          
            operand2 = true;                           // true
            result = operand1 && operand2;             // true

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //Задержка
            Console.ReadKey();
        }
    }
}
