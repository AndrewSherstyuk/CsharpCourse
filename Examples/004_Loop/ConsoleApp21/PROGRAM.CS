using System;
/// <summary>
/// Шкала температур Цельсий => Фаренгейт
/// Получить таблицу температур по Цельсию tc от -50 до +50 градусов а также их эквивалентов по шкале Фаренгейта tf, 
/// используя соотношение T(фарингейта) = 9/5*T(Цельсия) + 32;
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            // шкала температур Цельсий => Фаренгейт
            int temperatureCelsius; // текущее значение температуры по Цельсию
            double temperatureFahrenheit; // значение температуры по Фаренгейту

            temperatureCelsius = -50;

            Console.WriteLine("Шкала температур: Цельсий - Фаренгейт");

            while (temperatureCelsius <= 50)
            {
                temperatureFahrenheit = 9.0 / 5.0 * temperatureCelsius + 32;
                temperatureCelsius++;
                
                Console.WriteLine("{0} C => {1} F", temperatureCelsius, temperatureFahrenheit);
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
