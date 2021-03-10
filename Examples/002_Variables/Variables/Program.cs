using System;

namespace Variables
{
    class Program
    {
        static void Main()
        {
            float float1 = 0.123456789123456789f;
            double double1 = 0.123456789123456789f;
            decimal decimal1 = 0.123456789123456789m;

            Console.WriteLine(float1);
            Console.WriteLine(float.MaxValue);
            
            Console.WriteLine(new string('*', 10));
            
            Console.WriteLine(double1);
            Console.WriteLine(new string('*', 10));

            Console.WriteLine(decimal1);

            //Задаржка
            Console.ReadKey();
        }
    }
}
