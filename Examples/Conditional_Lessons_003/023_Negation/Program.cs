using System;

/// <summary>
/// Отрицания (НЕТ) - ! - [NOT]
/// </summary>
namespace _023_Negation
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false;
            bool operand2 = false;
            bool result = false;

            // Таблица истинности для Отрицания (НЕТ) - ! - [NOT]

            // !false  = true
            // !true  = false   

            Console.WriteLine("Таблица истинности для Отрицания (НЕТ) - ! - [NOT]");
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //!false  = true  
            operand1 = false;        //true
            result = !operand1;      //false

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //!true  = false   
            operand1 = true;        //true
            result = !operand1;     //false

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            //Задержка
            Console.ReadKey();
        }
    }
}
