using System;

/// <summary>
/// Иногда возникает необходимость создать один и тот же метод, 
/// но с разным набором параметров. И в зависимости от 
/// имеющихся параметров применять определенную версию метода. 
/// Такая возможность еще называется перегрузкой методов 
/// (method overloading).
/// </summary>
namespace _017_Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();

            Console.WriteLine()

            Method();
            Method("Hello");
            Method(10);
            Method(10, 20);
            Method(10, "Hello");

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// 1-я перегрузка метода 
        /// </summary>
        static void Method()
        {
            Console.WriteLine("Hello from First overload");
        }

        /// <summary>
        /// 2-я пергрузка
        /// </summary>
        /// <param name="parameter"></param>
        static void Method(string parameter)
        {
            Console.WriteLine(parameter);
        }

        /// <summary>
        /// 3-я пергрузка
        /// </summary>
        /// <param name="parameter"></param>
        static void Method(int parameter)
        {
            Console.WriteLine(parameter);
        }

        /// <summary>
        /// 5-я пергрузка (сумма 2-х аргументов)
        /// </summary>
        /// <param name="parameter"></param>
        static void Method(int parameter1, int parameter2)
        {
            Console.WriteLine(parameter1 + parameter2);
        }

        /// <summary>
        /// 6-я пергрузка (сумма 2-х аргументов)
        /// </summary>
        /// <param name="parameter"></param>
        static void Method(int parameter1, string parameter2)
        {
            Console.WriteLine(parameter1 + parameter2);
        }

        /*
        //Ошибка, так как ерегруженные методы не могут 
        // отличаться возвращаемыми значениями.
        /// <summary>
        /// 7-я пергрузка
        /// </summary>
        /// <param name="parameter"></param>
        static string Method(string parameter)
        {
            Console.WriteLine(parameter);
            return parameter;
        }
        */
    }
}
