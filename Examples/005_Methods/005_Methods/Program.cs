using System;

/// <summary>
/// Функция
/// </summary>
namespace _005_Methods
{
    class Program
    {
        static void Main()
        {
            int summand1 = 10;
            int summand2 = 20;

            //Переменная для хранения результата 
            int result = Summing(summand1, summand2);

            Console.WriteLine(string.Format(@"{0} + {1} = {2}", summand1, summand2,result));

            //Или же 2-й вариант вызова (без предварительного создания переменной для хранения результата)
            Console.WriteLine(string.Format(@"{0} + {1} = {2}", summand1, summand2, Summing(summand1, summand2)));

            //Или же 3-й вариант вызова (без предварительного создания переменных)
            Console.WriteLine(string.Format(@"{0} + {1} = {2}", 10, 20, Summing(10, 20)));

            //Задержка
            Console.ReadKey();
        }

        //Создаем метод с именем Summing, который принимает два целочисленных аргумента и возвращает целочисленное значение.
        //В теле метода, целочисленной локальной переменной result, присваиваем сумму аргументов summand1 и summand2, 
        //используя ключевое слово return, возвращаем значение переменной result.

        /// <summary>
        /// Сложение двух целых чисел.
        /// </summary>
        /// <param name="summand1">Первое слагаемое</param>
        /// <param name="summand2">Второе слагаемое</param>
        /// <returns></returns>
        static int Summing(int summand1, int summand2)
        {
            //Создаем локальную переменную result и присваевам ей значение 
            //суммы аргументов summand1 и summand2, 
            int result = summand1 + summand2;

            return result;
        }
    }
}
