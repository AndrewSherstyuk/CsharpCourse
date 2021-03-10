using System;

/// <summary>
/// Для хранения данных в программе применяются переменные. 
/// Переменная представляет именнованную область памяти, в которой хранится 
/// значение определенного типа. Переменная имеет тип, имя и значение. 
/// Тип определяет, какого рода информацию может хранить переменная.
/// </summary>
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем переменную с именем variable, типа byte.
            byte variable;

            // Присваиваем значение 10 переменной с именем variable
            variable = 10;

            // Выводим значение переменной - variable, на экран.
            Console.WriteLine(variable);

            //Присвоение значения переменной variableOptionTwo в момент создания переменной
            byte variableOptionTwo = 10;

            // Выводим значение переменной - variableOptionTwo, на экран.
            Console.WriteLine(variableOptionTwo);

            // Задержка.
            Console.ReadKey();
        }
    }
}
