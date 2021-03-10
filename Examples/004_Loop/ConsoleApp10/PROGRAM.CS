using System;

/// <summary>
/// Оператор безусловного перехода - goto.
/// </summary>
/// 
namespace Loop
{
    class Program
    {
        static void Main()
        {
            // mylabel - метка, на которую будет произведен переход оператором goto.
            goto mylabel;
            
            Console.WriteLine("Данный код не выполняется!");

            //С строки 15 оператор безусловного перехода сразу переходит на 19 строку
            mylabel: Console.WriteLine("Hello World");

            //Задержка
            Console.ReadLine();
        }
    }
}
