using System;

/// <summary>
/// Aвтоматические свойства
/// Свойства управляют доступом к полям класса. Однако что, 
/// если у нас с десяток и более полей, то определять каждое поле
/// и писать для него однотипное свойство было бы утомительно. 
/// Поэтому в фреймворк .NET были добавлены автоматические свойства. 
/// Автоматически реализуемые свойства это более лаконичная форма свойств, их есть смысл использовать,
/// когда в методах доступа (get и set) не требуется дополнительная логика. 
/// При создании автоматически реализуемых свойств, компилятор создаст закрытое, анонимное резервное поле, 
/// которое будет доступно с помощью методов get и set свойства.
/// </summary>
namespace _006_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса Student с именем student.
            Student student = new Student();

            student.Name = "Vasya";
            student.Age = 20;

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);

            Console.WriteLine(new string('-', 30));

            //Создаем экземпляр класса Student с именем student1.
            Student student1 = new Student() { Name= "Alexs", Age = 10 };

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);

            Console.ReadKey();
        }
    }

    class Student
    {
        /// <summary>
        /// Имя студента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст студента
        /// </summary>
        public int Age { get; set; }
    }
}
