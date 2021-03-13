using System;
using Microsoft.SmallBasic.Library;

namespace _018_ClassFieldArray
{
    class Program
    {
        static void Main()
        {
            Turtle.Move(100);

            Student student1 = new Student("Vasya", 25);
            Student student2 = new Student("Peter", 36);
            Student student3 = new Student("Roma", 28);
            Student student4 = new Student("Goshа", 19);

            Student[] students = new Student[4];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;

            StudentClass studentClass = new StudentClass(students);

            Console.WriteLine(studentClass.GetStudentAmount());

            Console.ReadLine();
        }
    }

    class StudentClass
    {
        private Student[] arrayStudent;

        public Student[] ArrayStudent
        {
            get { return arrayStudent; }
            set { arrayStudent = value; }
        }

        public StudentClass(Student[] arrayStudent)
        {
            this.arrayStudent = arrayStudent;
        }

        public int GetStudentAmount()
        {
            return arrayStudent.Length;
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
