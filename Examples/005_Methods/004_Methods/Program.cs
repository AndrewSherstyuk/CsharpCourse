using System;

/// <summary>
/// Функция
/// </summary>
namespace _004_Methods
{
    class Program
    {
        static void Main()
        {
            //В теле метода Main создаем строковую локальную переменную с именем concatenation
            //и присваиваем ей возвращаемое значение метода Function.
            //в качестве аргумента передаем строку - Alex.
            string concatenation = Function("Alexey");
            
            //Вывод значения переменной concatenation на экран
            Console.WriteLine(concatenation);

            //Задержка
            Console.ReadKey();
        }

        //Создаем метод с именем Function, который принимает один строковой аргумент и возвращает строковое значение.
        //В теле метода, строковой локальной переменной concatenation, присваиваем конкатенацию строк и аргумента, 
        //используя ключевое слово return, возвращаем значение переменной concatenation.

        /// <summary>
        /// Функция для вывода приветствия
        /// </summary>
        /// <param name="name">Имя слова которое выводим</param>
        /// <returns>Приветствие</returns>
        static string Function(string name)
        {
            //1-й вариант конкатенации
            //string concatenation = "Hello " + name + "!";

            //2-й вариант конкатенации
            //string concatenation = string.Concat("Hello ", name, "!");

            //3-й вариант конкатенации
            string concatenation = string.Format(@"Hello {0}!", name);
            
            return concatenation;
        }
    }
}
