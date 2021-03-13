using System;

/// <summary>
/// Поля для чтения можно инициализировать при их объявлении 
/// либо инициилизировать и изменять в конструкторе. Инициализировать или 
/// изменять их значение в других местах нельзя, можно только считывать их значение.
/// Поле для чтения объявляется с ключевым словом readonly:
/// </summary>
namespace _011_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MathsLibrary с именем mathsLibrary.
            MathsLibrary mathsLibrary = new MathsLibrary(152);

            //Попытка присвоить значение приведет к ошибке уровня компиляции
            //mathsLibrary.field = 15;

            Console.WriteLine(mathsLibrary.field);

            //Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MathsLibrary
    /// </summary>
    class MathsLibrary
    {
        /// <summary>
        /// Поле только для чтения
        /// Инициализировать можно при объявлении
        /// </summary>
        public readonly double field = 27;

        /// <summary>
        /// Конструктор класса MathsLibrary
        /// </summary>
        public MathsLibrary(double fieldValue)
        {
            this.field = fieldValue;
        }

        /// <summary>
        /// Метод для изменения поля 
        /// </summary>
        public void ChangeField()
        {
            //В методе нельзя менять значение поля только для чтения!
            //field = 1949;
        }


    }
}
