using System;

/// <summary>
/// Комбинация checked и unchecked
/// Комбинация проверки запрета проверки переполнения.
/// </summary>
namespace _024_Checked_and_Unchecked
{
    class Program
    {
        static void Main()
        {
            checked
            {
                byte a = 254;
                byte b = 255;

                checked
                {
                    a++;
                
                    //unchecked
                    {
                        a++;
                    };
                }
                
            }
        }
    }
}
