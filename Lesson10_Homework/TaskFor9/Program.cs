using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor9
{
    class Program
    {
        static void Main(string[] args)
        {
            //The count is equal if the parameters are equal. The winner is the one who has at least one parameter larger.

            ICharacter unicorn1 = new Unicorn("STORMBRINGER", 65, 50, 46);
            ICharacter unicorn2 = new Unicorn("SEAGULP", 65, 50, 45);

            double distance = 100;
            double damage = 0;

            do
            {
                unicorn1.Attack(unicorn2, ref distance, ref damage);
                unicorn2.Defend(damage);
                if (unicorn2.Agility + unicorn2.Strength + unicorn2.Health <= 0) break;

                unicorn2.Attack(unicorn1, ref distance, ref damage);
                unicorn1.Defend(damage);
                if (unicorn1.Agility + unicorn1.Strength + unicorn1.Health <= 0) break;
            }
            while (distance >= 10);

            Console.WriteLine("\n" + new string('=', 50) + "\n" + new string('=', 50));

            if ((Unicorn)unicorn1 < (Unicorn)unicorn2)
            {
                Console.WriteLine($"The winner is {((Unicorn)unicorn2).Name}");
            }
            else if ((Unicorn)unicorn1 == (Unicorn)unicorn2)
            {
                Console.WriteLine("No winners: equal count");
            }
            else
            {
                Console.WriteLine($"The winner is {((Unicorn)unicorn1).Name}");
            }

            Console.ReadKey();
        }
    }

    interface ICharacter
    {
        double Health { get; set; }
        double Agility { get; set; }
        double Strength { get; set; }
        void Attack(ICharacter aim, ref double distance, ref double damage);
        void Defend(double damage);
    }

    class Unicorn : ICharacter
    {
        public Unicorn(string n, double h, double a, double s)
        {
            Name = n;
            Health = h;
            Agility = a;
            Strength = s;
        }
        public string Name { get; set; }
        public double Health { get; set; }
        public double Agility { get; set; }
        public double Strength { get; set; }
        public int AttackNumber { get; set; } = 1;
        public int DefenceNumber { get; set; } = 1;

        public void Attack(ICharacter aim, ref double distance, ref double damage)
        {
            double totalPower1 = Math.Round((aim.Health + aim.Agility + aim.Strength), 2);

            aim.Health = aim.Health * 0.75;
            aim.Agility = aim.Agility * 0.75;
            aim.Strength = aim.Strength * 0.75;
            distance = distance - 10;

            double totalPower2 = Math.Round((aim.Health + aim.Agility + aim.Strength), 2); ;

            damage = totalPower1 - totalPower2;

            Console.WriteLine($"{Name.ToUpper()}'S ATTACKING {(aim as Unicorn).Name}, ATTACK #{AttackNumber} \n{new string('=', 30)}");
            //Console.WriteLine($"Enemy's abilities after this attack {AttackNumber}: \nHealth = {aim.Health} \nAgility = {aim.Agility} \nStrength = {aim.Strength} \nDistance = {distance}");
            Console.WriteLine($"{(aim as Unicorn).Name} Power before attack = {totalPower1} \n{(aim as Unicorn).Name} Power after attack = {totalPower2} \nDAMAGE = {damage}\nDISTANCE = {distance}\n\n");

            AttackNumber++;
        }

        public void Defend(double damage)
        {
            Console.WriteLine($"{Name}'S DEFENDING OPERATION #{DefenceNumber} \n{new string('=', 50)}");

            double totalPower1 = Math.Round((Health + Agility + Strength), 2);

            Health = Health + damage / 6;
            Agility = Agility + damage / 6;
            Strength = Strength + damage / 6;

            double totalPower2 = Math.Round((Health + Agility + Strength), 2);

            Console.WriteLine($"Damage compensated by {totalPower2 - totalPower1}, from {totalPower1} to {totalPower2}\n\n");
            DefenceNumber++;
        }

        public static bool operator >(Unicorn u1, Unicorn u2)
        {
            return u1.Strength + u1.Agility + u1.Health > u2.Strength + u2.Agility + u2.Health;
        }

        public static bool operator <(Unicorn u1, Unicorn u2)
        {
            return u1.Strength + u1.Agility + u1.Health < u2.Strength + u2.Agility + u2.Health;
        }

        public static bool operator ==(Unicorn u1, Unicorn u2)
        {
            return u1.Strength + u1.Agility + u1.Health == u2.Strength + u2.Agility + u2.Health;
        }
        public static bool operator !=(Unicorn u1, Unicorn u2)
        {
            return u1.Strength + u1.Agility + u1.Health != u2.Strength + u2.Agility + u2.Health;
        }
    }
}
