using System;

/// <summary>
/// Оператор безусловного перехода - goto.
/// В связке с условными конструкциями
/// </summary>

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Счетчик для подсчета количество переходов оператором goto 
            int counter = 0;

            //mylabel - метка, на которую будет произведен переход оператором goto.
            mylabel:
                //С помощью декремента увеличиваем счетчик
                counter++;
                Console.WriteLine("Количество переходов = {0}", counter);

                //Если количество переходов меньше чем 5, тогда снова осуществляем переход
                if (counter < 5)
                {
                    //Переход на метку mylabel
                    goto mylabel;
                }

            //Оттенить конец выполнения 
            Console.WriteLine("Конец выполнения!");

            //Задержка
            Console.ReadLine();
        }
    }
}
