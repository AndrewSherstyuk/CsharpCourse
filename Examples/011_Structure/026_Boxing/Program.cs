﻿using System;

/// <summary>
/// Упаковка/Распаковка
/// 
/// Упаковка (Boxing) - преобразование структурного типа (типа значения) в ссылочный тип 
/// (Object или любой другой тип интерфейса, реализуемый этим типом значения).
/// Когда тип значения упаковывается средой CLR, она создает программу-оболочку значения внутри
/// System.Object и сохраняет ее в управляемой куче.
/// 
/// Распаковка (Unboxing) - преобразование ссылочного типа в структурный тип.
/// Операция распаковки-преобразования извлекает тип значения из объекта.
/// Перед распаковкой среда выполнения проверяет совместимость между объектом и структурой,
/// в которую будет происходить распаковка.
/// </summary>
namespace _026_Boxing
{
    class Program
    {
        static void Main()
        {
            //Значимый тип
            int valueTypes = 10;

            // Упаковка переменной - а  (Boxing).
            object referenceType = valueTypes;

            // Распаковка объекта (UnBoxing).
            int againValueTypes = (int)referenceType;

            // Распаковка должна производиться только в тот тип, 
            // из которого производилась упаковка.
            // byte againValueTypes = (byte)referenceType;

            // Задержка
            Console.ReadKey();

        }
    }
}
