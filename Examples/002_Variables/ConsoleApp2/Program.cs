using System;
/// <summary>
/// Язык C# использует простые типы данных платформы .Net Framework, 
/// при этом в языке, для них, используются псевдонимы, по этому при рассмотрении 
/// мы будем указывать как псевдоним, так и полное название типа данных 
/// платформы .Net. Для компилятора нет разницы, какую форму записи названий вы используете.
/// </summary>

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            //Тип данных C# (псевдоним)
            byte variableFirst = 10;

            // Системный тип данных
            Byte variableSecond = 20;

            // Вывод значений переменных на экран.
            Console.WriteLine(variableFirst);
            Console.WriteLine(variableSecond);

            // Задержка.
            Console.ReadKey();
        }
    }
}
