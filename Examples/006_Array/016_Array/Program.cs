using System;

/// <summary>
///  Ключевое слово params, позволяет определить параметр метода, 
///  принимающий переменное количество аргументов.
/// </summary>
namespace _016_Array
{
    class Program
    {
        static void Main()
        {
            int[] @int = new int[4] { 1,2,3,4 };

            int[] @int1 = new int[5] { 1, 2, 3, 4, 5 };

            @int = @int1;
            @int1 = null;

            @int1 = new int[100];

            foreach (var item in @int)
            {
                Console.WriteLine(item);
            }

            int counter = 0;
            foreach (int item in @int)
            {
                @int[counter] = 10;
                Console.WriteLine(item);
                counter++;
            }

            //ShowArray("cdscsz", 1,2,3,4,5,6,7,8,9,10);

            ShowArray("", 1,2,34,5);

            // Задержка.
            Console.ReadKey();

            Console.WriteLine();
        }
        static void ShowArray(string Name, params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
