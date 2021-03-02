﻿using System;

/// <summary>
/// Конструкция switch/case. 
/// Представим, что Вы загадываете эту загадку пользователю. Создайте программу, которая будет считывать с консоли ответ:
/// если пользователь вводит "Троллейбус", мы выводим в консоль "Правильно!" 
/// если пользователь вводит "Сдаюсь", мы выводим в консоль "Правильный ответ: троллейбус." 
/// если пользователь вводит любой другой ответ, мы выводим в консоль "Подумай еще." 
/// </summary>

namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Что это такое: синий, большой, с усами и полностью набит зайцами?");

            string key = Console.ReadLine();

            switch (key)
            {
                case "Троллейбус":
                    Console.WriteLine("Правильно");
                    break;
                case "Сдаюсь":
                    Console.WriteLine("А жаль...(");
                    break;
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
