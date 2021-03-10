using System;

/// <summary>
/// Множественный возврата из метода (return) использую конструкцию
/// if - else if - else
/// </summary>
namespace _007_Methods
{
    class Program
    {
        static void Main()
        {
            int argument1 = 20;
            int argument2 = 20;

            //Переменная для хранения результата 
            string result = Compare(argument1, argument2);

            Console.WriteLine(result);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для сравнения двух чисел
        /// </summary>
        /// <param name="argument1">1-вое число для сравнения</param>
        /// <param name="argument2">2-вое число для сравнения</param>
        /// <returns>Результат сравнения</returns>
        static string Compare(int argument1, int argument2)
        {
            string res;
            if (argument1 < argument2)
            {
                res =  string.Format(@"{0} < {1}", argument1, argument2);
            }
            else if (argument1 > argument2)
            {
                res =  string.Format(@"{0} > {1}", argument1, argument2);
            }
            else
            {
                res = string.Format(@"{0} = {1}", argument1, argument2);
            }

            return res;
        }
    }
}
