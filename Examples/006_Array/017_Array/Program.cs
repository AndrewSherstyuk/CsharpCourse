using System;

/// <summary>
/// Параметр с ключевым словом params, должен быть только один 
/// и стоять последним в списке параметров метода.
/// </summary>
namespace _017_Array
{
    class Program
    {
        static void Main()
        {
            ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay.
            Console.ReadKey();
        }
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
