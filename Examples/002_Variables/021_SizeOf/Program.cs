using System;

/// <summary>
///  Оператор sizeof - позволяет получить размер значения в байтах для указанного типа.
///  Оператор sizeof можно применять к следующим типам: 
///  byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool.
///  Возвращаемые оператором sizeof значения имеют тип int.
/// </summary>
namespace _021_SizeOf
{
    class Program
    {
        static void Main()
        {
            //Целочисленные типы 
            int byteSize = sizeof(byte);
            int shortSize = sizeof(short);
            int intSize = sizeof(int);
            int longSize = sizeof(long);
            
            //Вещественные типы
            int floatSize = sizeof(float);
            int doubleSize = sizeof(double);
            
            //Десятичные типы 
            int decimalSize = sizeof(decimal);

            //Нечесловые типы
            int bollSize = sizeof(bool);
            int charSize = sizeof(char);

            Console.WriteLine("Целочисленные типы ");
            Console.WriteLine(string.Format(@"Размер типа byte {0} байт", byteSize));
            Console.WriteLine(string.Format(@"Размер типа short {0} байт", shortSize));
            Console.WriteLine(string.Format(@"Размер типа int {0} байт", intSize));
            Console.WriteLine(string.Format(@"Размер типа long {0} байт", longSize));

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Вещественные типы");
            Console.WriteLine(string.Format(@"Размер типа float {0} байт", floatSize));
            Console.WriteLine(string.Format(@"Размер типа double {0} байт", doubleSize));

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Десятичные типы");
            Console.WriteLine(string.Format(@"Размер типа decimal {0} байт", decimalSize));

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Нечесловые типы");
            Console.WriteLine(string.Format(@"Размер типа bool {0} байт", bollSize));
            Console.WriteLine(string.Format(@"Размер типа char {0} байт", charSize));

            // Задержка.
            Console.ReadKey();
        }
    }
}
