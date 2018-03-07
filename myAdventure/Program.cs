using System;

namespace myAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Alouris");
            Monster myMonster = new Monster("Goblin");
            myHero.HeroCreated();
            Console.WriteLine("A {0} appears!", myMonster.Species);

            myHero.TakeDamage(3);
        }
    }

    class Hero
    {
        // Fields
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        // Constructor
        public Hero(string HeroName)
        {
            Name = HeroName;
            Health = 10;
            Damage = 2;
        }

        // Method
        public void HeroCreated()
        {
            Console.WriteLine("A new Hero joins the fight!");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Damage: " + Damage);
        }

        public void TakeDamage(int incomingDamage)
        {
            Health -= incomingDamage;
            Console.WriteLine(Health);
        }
    }

    class Monster
    // Look into inheritance.
    {
        public string Species { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Monster(string species)
        {
            Species = species;
            Health = 5;
            Damage = 1;
        }

    }
    
}
