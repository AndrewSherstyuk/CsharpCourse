using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.WriteLine("\nPlease enter a weather-related word you want to translate from Russian into English");

            string word = Console.ReadLine();

            switch (word)
            {
                case "дождь":
                    {
                        Console.WriteLine("rain");
                        break;
                    }
                case "снег":
                    {
                        Console.WriteLine("snow");
                        break;
                    }
                case "погода" :
                    {
                        Console.WriteLine("weather");
                        break;
                    }
                case "тепмература":
                    {
                        Console.WriteLine("temperature");
                        break;
                    }
                case "давление":
                    {
                        Console.WriteLine("pressure");
                        break;
                    }
                case "солнечно":
                    {
                        Console.WriteLine("sunny");
                        break;
                    }
                case "облачно":
                    {
                        Console.WriteLine("cloudy");
                        break;
                    }
                case "ветер":
                    {
                        Console.WriteLine("wind");
                        break;
                    }
                case "ураган":
                    {
                        Console.WriteLine("hurricane");
                        break;
                    }
                case "туман":
                    {
                        Console.WriteLine("fog");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There's no translation for this word in our dictionary");
                        break;
                    }                    
            }

            goto Start;
        }
    }
}
