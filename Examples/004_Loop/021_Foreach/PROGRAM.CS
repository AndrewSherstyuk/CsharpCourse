using System;

/// <summary>
///  цикл foreach, удобный при работе с массивами, 
///  коллекциями и другими подобными контейнерами данных. Его синтаксис:
/// foreach(тип идентификатор in контейнер) оператор
/// </summary>
namespace _021_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            array[0] = "zeroElement";
            array[1] = "firstElement";
            array[2] = "secondElement";

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Задержка.
            Console.ReadKey();
        }
    }
}
