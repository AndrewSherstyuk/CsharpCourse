using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Please enter the {i + 1} product's name");
                string productName = Console.ReadLine();

                Console.WriteLine($"Please enter the {i + 1} shop");
                string shopName = Console.ReadLine();

                Console.WriteLine($"Please enter the {i + 1} price");
                decimal price = 0;
                try
                {
                    price = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                prices[i] = new Price(productName, shopName, price);
            }

            Console.WriteLine("Please enter the shop name");
            string sN = Console.ReadLine();

            int number = 0;

            try
            {
                for (int j = 0; j < prices.Length; j++)
                {
                    if (prices[j].ShopName == sN)
                    {
                        Console.WriteLine($"{prices[j].ProductName} - {prices[j].PriceOfProduct}");
                        number++;
                    }
                }
                if (number == 0)
                {
                    throw new Exception($"There's no {sN} shop in our list");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            for (int l = 0; l < prices.Length; l++)
            {
                Console.WriteLine("Product name = {0}, Shop name = {1}, Price is {2}", prices[l].ProductName, prices[l].ShopName, prices[l].PriceOfProduct);
            }

            //Array.Sort(prices);

            //prices.OrderBy(x => x.ProductName);

            //НЕ ПОНЯЛ КАК СОРТИРОВАТЬ ПО ОТДЕЛЬНОМУ ПОЛЮ

            for (int l = 0; l < prices.Length; l++)
            {
                Console.WriteLine("Product name = {0}, Shop name = {1}, Price is {2}", prices[l].ProductName, prices[l].ShopName, prices[l].PriceOfProduct);
            }

            Console.ReadKey();
        }
    }

    struct Price : IComparable<Price>
    {
        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public decimal PriceOfProduct { get; set; }

        public Price(string n, string s, decimal p)
        {
            ProductName = n;
            ShopName = s;
            PriceOfProduct = p;
        }
        public int CompareTo(Price other)
        {
            int result = ShopName.CompareTo(other.ShopName);
            return result != 0 ? result : ShopName.CompareTo(other.ShopName);
        }
    }
}
