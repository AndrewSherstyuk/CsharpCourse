using System;

/// <summary>
/// 
/// </summary>
namespace _017_ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Vasya", 25);
            Student student2 = new Student("Peter", 36);
            Student student3 = new Student("Roma", 28);
            Student student4 = new Student("Goshа", 19);

            Student[] students = new Student[4];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(string.Format(@"{0}-й студент {1} - его возраст {2}", i, students[i].Name, students[i].Age));
            }

            Console.WriteLine(new string('*', 30));
            Console.WriteLine(string.Empty);

            //или вывод через foreach
            int counter = 0;
            foreach (Student student in students)
            {
                Console.WriteLine(string.Format(@"{0}-й студент {1} - его возраст {2}", counter, student.Name, student.Age));
                counter++;
            }

            Console.ReadLine();
        }
    }

    class Student
    {
        private string name;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
