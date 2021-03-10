using System;

// Преобразование типа - это преобразование значения переменной одного типа в значение другого типа.
// Существует явное (explicit) и неявное (implicit) преобразование типов.
namespace _006
{
    class Program
    {
        static void Main()
        {
            #region Неявное преобразование типов
            
            //Неявное преобразование тип byte в тип int, фактически преобразование меньшего типа в больший
            byte @byte = 20;
            int @int = 0;

            @int = @byte;

            Console.WriteLine(@int);

            //Неявное преобразование тип long в тип decimal, фактически преобразование целого типа в вещественный
            long @long = 255;
            decimal @decimal = 0m;
            @decimal = @long;

            Console.WriteLine(@decimal);
            #endregion

            #region Явное преобразование типа:

            // Явное преобразование значения типа - int в тип byte. 
            // (преобразование большего типа в меньший, приводит к потере части результата)
            int @int_ = 800;
            byte @byte_ = 0;

            //ОШИБКА.
            //@byte_ = @int_;
            
            @byte_ = (byte)@int_;

            Console.WriteLine(@byte_);

            //
            decimal @decimal_= 255.35m;
            long @long_ = 0;

            //ОШИБКА.
            //@long = @decimal;

            @long_ = (long)@decimal_;

            Console.WriteLine(@long_);

            #endregion

            // Задержка.
            Console.ReadKey();
        }
    }
}
