using System;

/// <summary>
/// Оператор безусловного перехода - goto.
/// goto (от англ. go to — «перейти на») — оператор безусловного перехода 
/// (перехода к определённой точке программы, обозначенной меткой)
/// </summary>

namespace Loop
{
    class Program
    {
        static void Main()
        {
            // mylabel - метка, на которую будет произведен переход оператором goto.
            mylabel:
                Console.WriteLine("Hello World");
            goto mylabel;
        }
    }
}
