using System;
using System.Threading;

/// <summary>
/// Деструктор 
/// </summary>
namespace _003_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            //Отрабативает 2-3 итерации
            //Елси длительное время выполнение, тогда 
            //деструктор не отрабатывает полностью 
            //время работы деструктора до 40 секунд
            MyClass myClass = new MyClass();

            //Console.ReadLine();
        }
}

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Деструктор
        /// Время жизни обектов ограничено индивидуально,
        /// для разных конфигураций систем
        /// </summary>
        ~MyClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                //Усипляем поток на 1 секунду, всего 10 секунд
                Thread.Sleep(1000);
            }
        }
    }
}
