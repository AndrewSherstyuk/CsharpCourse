using System;

/// <summary>
/// Модификатор параметра ref принудительно организует вызов по ссылке, а не по значению. 
/// Этот модификатор указывается как при объявлении, так и при вызове метода.
/// </summary>
namespace _010_Methods
{
    class Program
    {
        static void Main()
        {
            //ref-параметр необходимо передавать инициализированным, и можно пользоваться его исходным значением.
            int x1 = 10;

            int result = Method(ref x1);

            Console.WriteLine(string.Format(@"{0}, {1}", x1, result));

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод с ref параметром
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int Method(ref int x)
        {
            int y = x * 5;

            x = 7;

            return y;
        }
    }
}
