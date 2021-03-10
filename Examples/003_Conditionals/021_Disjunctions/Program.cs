using System;

/// <summary>
/// Дизъю́нкция (от лат. disjunctio — разобщение), логи́ческое сложе́ние, 
/// логи́ческое ИЛИ, включа́ющее ИЛИ; иногда просто ИЛИ — логическая операция, 
/// по своему применению максимально приближённая к союзу 
/// «или» в смысле «или то, или это, или оба сразу».
/// </summary>
namespace _021_Disjunctions
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false;
            bool operand2 = false;
            bool result = false;

            // Таблица истинности для Дизъюнкции (ИЛИ) - || - [OR]

            // Если хоть одно из выражений операции операции Дизъюнкции имеет значение true -
            // все выражение имеет значение true, иначе - false

            // false || false = false                  true || false = true         
            // false || true = true                    true || true = true

            Console.WriteLine("Таблица истинности для Дизъюнкции (ИЛИ) - || - [OR]");
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // false || false = false         
            operand1 = false;                           // false          
            operand2 = false;                           // false
            result = operand1 || operand2;              // false

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // false || true = true   
            operand1 = true;                           // false          
            operand2 = false;                          // true
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // true || false = true   
            operand1 = false;                           // true          
            operand2 = true;                          // false
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            // true || true = true   
            operand1 = true;                           // true          
            operand2 = true;                           // true
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //Задержка
            Console.ReadKey();
        }
    }
}
