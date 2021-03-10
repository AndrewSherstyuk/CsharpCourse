using System;

namespace _027_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;

            int a = 15;
            
            decimal b = 10.0m;
            
            result = a < b;   // Сравнение значения типа int, со значением типа decimal - допустимо.

            string c = "string";

            //Сравнение значения типа int, со значением типа string - не допустимо.
            //Раскомментировать
            // result = c < a; 

            // Задержка.
            Console.ReadKey();
        }
    }
}
