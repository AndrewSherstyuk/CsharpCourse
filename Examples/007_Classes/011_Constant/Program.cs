﻿using System;

/// <summary>
/// Константы
/// Константы характеризуются следующими признаками:
/// Константа должна быть проинициализирована при определении
/// После определения значение константы не может быть изменено
/// Константы предназначены для описания таких значений, которые 
/// не должны изменяться в программе.Для определения констант используется ключевое слово const:
/// </summary>
namespace _011_Constant
{
    class Program
    {
        static void Main()
        {
            //Разница
            //1) Константы должны быть определены во время компиляции, а поля для чтения могут быть определены во время выполнения программы.
            //2) Соответственно инициализировать константу можно устанновить только при ее определении.
            //3) Поле для чтения можно инициализировать либо при его определении, либо в конструкторе класса.

            //Ошибка уровня компиляции
            //MathsLibrary.Pi = 3.14;

            Console.WriteLine(MathsLibrary.Pi);

            //Задержка
            Console.ReadKey();

        }
    }

    /// <summary>
    /// Класс MathsLibrary
    /// </summary>
    class MathsLibrary
    {
        /// <summary>
        /// Константа Pi
        /// </summary>
        public const double Pi = 3.141;

        /// <summary>
        /// Конструктор класса MathsLibrary
        /// </summary>
        /// <param name="Pi"></param>
        public MathsLibrary(double Pi)
        {
            // Попытка присвоить значение приведет к ошибке уровня компиляции
            //this.Pi = Pi;
        }
    }
}
