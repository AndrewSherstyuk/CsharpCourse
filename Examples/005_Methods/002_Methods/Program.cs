﻿using System;

/// <summary>
/// Функция — это подпрограмма специального вида, которая, кроме получения параметров,
/// выполнения действий и передачи результатов работы через параметры имеет ещё 
/// одну особенность— она всегда должна возвращать результат. 
/// Вызов функции является, с точки зрения языка программирования, выражением, он может 
/// использоваться в других выражениях или в качестве правой части присваивания.
/// </summary>
namespace _002_Methods
{
    class Program
    {
        static void Main()
        {

            //В теле метода Main создаем строковую локальную переменную с именем functionResult
            // и присваиваем ей возвращаемое значение метода Function.
            string functionResult = Function();

            //Вывод значения переменной functionResult на экран
            Console.WriteLine(functionResult);

            //Задержка
            Console.ReadKey();
        }

        //создаем метод с именем Function, который ничего не 
        //принимает и возвращает строковое значение.
        // В теле метода, используя ключевое 
        //слово return, возвращаем строку - Hello!

        /// <summary>
        /// Функция для вывода приветствия
        /// </summary>
        /// <returns>Приветствия</returns>
        static string Function()
        {
            string @string = "Hello from Function!";
            return @string;
        }
    }
}
