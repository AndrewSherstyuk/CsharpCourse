using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {       
            Pupil vasya = new BadPupil("Vasya");
            Pupil kolya = new GoodPupil("Kolya");
            Pupil nadya = new GoodPupil("Nadya");
            Pupil natasha = new ExcellentPupil("Natasha");

            ClassRoom classRoom = new ClassRoom(vasya, kolya, nadya, natasha);

            classRoom.Show();

            Console.ReadKey();
        }
    }

    class ClassRoom
    {
        private Pupil[] pupils;
        
        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }

        public void Show()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.ShowName();
                pupil.Study();
                pupil.Write();
                pupil.Read();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }

    class Pupil
    {
        protected string name;

        protected string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Pupil(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.Write(new string(' ', 25));
            
            char[] n = name.ToUpper().ToCharArray();

            foreach(char c in n)
            {
                Console.Write($" {c}");
            }
            
            Console.Write("\n" + new string('=', 60) + "\n");
        }

        public virtual void Study()
        {
            Console.Write("Average academic performance of the pupil is: ");
        }

        public virtual void Read()
        {
            Console.Write("Reading skills of this guy are: ");
        }

        public virtual void Write()
        {
            Console.Write("Complexity and correctness of writing the pupil has is: ");
        }

        public virtual void Relax()
        {
            Console.Write("Amount of time the pupil stends on relaxing is: ");
        }
    }

    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string name) : base(name) { }

        public override void Study()
        {
            base.Study();
            Console.Write("Excellent\n");
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Excellent\n");
        }

        public override void Write()
        {
            base.Write();
            Console.Write("Excellent\n");
        }

        public override void Relax()
        {
            base.Relax();
            Console.Write("Not too much\n");
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }

        public override void Study()
        {
            base.Study();
            Console.Write("Good\n");
        }

        public override void Read()
        {
            base.Read();
            Console.Write(" Good\n");
        }

        public override void Write()
        {
            base.Write();
            Console.Write("Good\n");
        }

        public override void Relax()
        {
            base.Relax();
            Console.Write("Enough\n");
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }

        public override void Study()
        {
            base.Study();
            Console.Write("Bad\n");
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Bad\n");
        }

        public override void Write()
        {
            base.Write();
            Console.Write("Bad\n");
        }

        public override void Relax()
        {
            base.Relax();
            Console.Write("A lot\n");
        }
    }

}
