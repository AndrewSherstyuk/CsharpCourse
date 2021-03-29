using System;

/// <summary>
/// Поколения
/// Поколения0 - Объекты не проверяются сборщиком мусора
/// Поколения1 - Объекты пережившие одну проверку сборщику мусора.
/// Поколения2 - Объекты пережившие более чем одну проверку сборщику мусора.
/// </summary>
namespace _007_GarbageCollector
{
    class Program
    {
        static void Main()
        {
            OtherObject[] otherObject = new OtherObject[1000];

            for (int i = 0; i < otherObject.Length; i++)
            {
                //Удалять обект нельзя
                otherObject[i] = new OtherObject();
                //Номер генерации 
                Console.WriteLine(GC.GetGeneration(otherObject));
                //Параметр метода - надо ли запускать сборщик мусора
                Console.WriteLine(GC.GetTotalMemory(false));
            }

            Console.WriteLine(new string('-',10));

            //Максимальное количество генераций
            
            Console.WriteLine(GC.MaxGeneration);
            //Количество проверок каждой генерации
            Console.WriteLine("Поколение 0 проверялось {0} раз", GC.CollectionCount(0));
            Console.WriteLine("Поколение 1 проверялось {0} раз", GC.CollectionCount(1));
            Console.WriteLine("Поколение 2 проверялось {0} раз", GC.CollectionCount(2));

            Console.ReadLine(); 
        }
    }


    /// <summary>
    /// Заполнения кучи
    /// </summary>
    class OtherObject
    {
        byte[] array = new byte[1024*50]; //50KB
    }
    class MyClass
    {
        byte[] array = new byte[1024]; //1KB

        /// <summary>
        /// Конструктор
        /// </summary>
        public MyClass()
        {
            Console.WriteLine(string.Format(@"Constructor {0}", this.GetHashCode()));
        }

        /// <summary>
        /// Деструктор 
        /// </summary>
        ~MyClass()
        {
            Console.WriteLine(string.Format(@"Destructor  {0}", this.GetHashCode()));
        }
    }
}
