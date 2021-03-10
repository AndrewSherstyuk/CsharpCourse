using System;

/// <summary>
/// Арифметические операторы (Arithmetic Operators) - +, −, *, /, %
/// </summary>
namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            #region Сложение (аddition) (+)
            //1-е слагаемое
            byte summand1 = 10;
            //2-e слагаемое
            byte summand2 = 20;

            //Переменная sum - для хранения результата сложения
            int sum = 0;

            //Сложение
            sum = summand1 + summand2;

            //Выводим значение переменной - sum, на экран.
            Console.WriteLine(sum);
            #endregion

            #region Вычитание (subtraction) (-)
            //Уменьшаемое 
            byte minuend = 30;
            //Вычитаемое 
            byte subtrahend = 10;

            //Переменная difference - результат выполненного действия вычитания.
            int difference = 0;
            difference = minuend - subtrahend;

            //Выводим значение переменной - difference, на экран.
            Console.WriteLine(difference);
            #endregion

            #region Умножение (multiplication) (*)
            //Множитель
            byte factor = 10;
            //Сомножитель
            byte co_factors = 20;

            //Переменная production результат произведения действия умножения.
            int production = 0;
            production = factor * co_factors;

            //Выводим значение переменной - production, на экран.
            Console.WriteLine(production);
            #endregion

            #region Деление (division) (/)
            //Делимое
            byte dividend = 5;
            //Делитель
            byte divisor = 2;

            //Частное от деления 
            int quotient = 0;
            //Остаток от деления.
            int remainder = 0;
            
            //Операция деления
            quotient = dividend / divisor;

            //Выводим значение переменной - quotient (целого от деления), на экран.
            Console.WriteLine(quotient);

            //Операция получения остатка от деления
            remainder = dividend % divisor;

            //Выводим значение переменной - remainder (остатка от деления), на экран.
            Console.WriteLine(remainder);
            #endregion

            // Задержка.
            Console.ReadKey();
        }
    }
}
