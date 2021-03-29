using System;

/// <summary>
/// Структура 
/// Структуру можно передать по ссылке, используя модификаторы out и ref.
/// DateTime - структура в С#
/// </summary>
namespace _010_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа
            Time time = new Time(21, 10, 30);

            //Выводим на консоль значение
            Console.WriteLine(time.ToString());

            //Добавляем 1 час 
            AddHour(ref time);

            //Снова выводим на консоль значение
            Console.WriteLine(time.ToString());

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод с ref параметором, добавляет 1 час
        /// </summary>
        /// <param name="time"></param>
        public static void AddHour(ref Time time)
        {
            time.Hours++;
        }

    }

    /// <summary>
    /// Стуктура Time
    /// </summary>
    struct Time
    {
        /// <summary>
        /// Часы
        /// </summary>
        public int Hours { get; set; }
        
        /// <summary>
        /// Минуты
        /// </summary>
        public int Minutes { get; set; }
        
        /// <summary>
        /// Секунды
        /// </summary>
        public int Seconds { get; set; }

        /// <summary>
        /// Конструктор структуры
        /// </summary>
        /// <param name="hours">Часы</param>
        /// <param name="minutes">Минуты</param>
        /// <param name="seconds">Секунды</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Переопределение метода ToString 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(@"{0}:{1}:{2}", Hours, Minutes, Seconds);
        }
    }
}
