using System;

/// <summary>
/// 
/// </summary>
namespace _014_Methods
{
    class Program
    {
        static void Main()
        {
            // Параметр, передаваемый по значению, фактически 
            //уничтожается при возврате значения методом

            int argument = 10;

            Console.WriteLine(argument);

            // В качестве аргумента передается не сама переменная - argument, а её копия.
            MultiplyByThree(argument);
            
            Console.WriteLine(argument);

            //Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для умножения на входящего числа на три
        /// </summary>
        /// <param name="x"></param>
        static void MultiplyByThree(int x)
        {
            x = x *3;
            Console.WriteLine("Значение int x в ходе выполнения метода = {0}", x);
        }
    }
}
