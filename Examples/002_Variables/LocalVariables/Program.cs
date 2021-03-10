﻿using System;

/// <summary>
/// Локальные переменные
/// Область видимости, или контекст переменной — это часть кода, 
/// в пределах которого доступна данная переменная. 
/// </summary>
namespace LocalVariables
{
    class Program
    {
        static void Main()
        {
            //В двух различных локальных областях 
            //можно хранить одноименные переменные.

            //Локальная область 1
            {
                string variable1 = "Hello";
                Console.WriteLine(variable1);
            }

            //Локальная область 2
            {
                string variable1 = "Hello";
                Console.WriteLine(variable1);
            }

            //Если в коде существуют локальные области, то запрещается 
            //хранить одноименные переменные за пределами локальных областей.
            //Раскомментировать - ошибка:  Переменная с таким именем 
            //уже существует в локальной области.

            //string variable1 = "Hello";

            // Задержка.
            Console.ReadKey();
        }
    }
}
