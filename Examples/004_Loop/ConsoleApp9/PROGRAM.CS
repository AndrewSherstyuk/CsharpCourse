using System;

/// <summary>
/// Цикл for вложенный в цикл for. 
/// ( Построение квадрата из звездочек - * )
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                // Выводим одну строку из 5 звездочек.
                for (int j = 0; j < 5; j++)
                {
                    if (i == 3)
                    {
                        if (j == 3)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else
                        Console.Write("*");
                }

                // Переход на новую строку.
                Console.WriteLine();
            }

            //Задержка.
            Console.ReadKey();
        }
    }
}
