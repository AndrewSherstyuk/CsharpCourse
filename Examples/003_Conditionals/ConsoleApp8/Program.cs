using System;

/// <summary>
/// Тернарная операция.
/// Используя тернарную операцию рассчитать скидку за общую стоимость товаров, 
/// при условии, что купили более 3 единиц товара, к-лво единиц товара пользователь 
/// должен вводит с клавиатуры.
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            // Общая стоимость.  
            double totalCost;
            // Цена за единицу товара.           
            double price = 20;
            // Скидка на общую стоимость - 10%.
            double discount = 0.9;    

            Console.WriteLine("Введите количество единиц товара");

            //Количество купленных товаров
            int quantity = Convert.ToInt32(Console.ReadLine());

            //Если к-лво купленных товаров более 3 единиц, тогда стоимость = цена за единицу * скидку * к-лво,
            //Иначе стоимость = цена за единицу * к-лво.
            totalCost = quantity > 3 ? price * quantity * discount : price * quantity;

            //Вывод информации об общей стоимости товаров
            Console.WriteLine(string.Format(@"Общая стоимость товара = {0}", totalCost));

            //Задержка
            Console.ReadKey();
        }
    }
}
