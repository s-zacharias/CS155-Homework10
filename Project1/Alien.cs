using System;
namespace Project1
{
    public class Alien
    {
        public int Health { get; set; } // 0 = dead, 100 = full
        public string Name { get; set; }

        public Alien(int health, string name)
        {
            Health = health;
            Name = name;
        }
    }

    public class SnakeAlien : Alien
    {
        private int damage = 10;
        private int Number { get; set; }

        public SnakeAlien(int health, string name, int number) : base(health, name)
        {
            Number = number;
            Health = health;
            Name = name;
        }

        public int getDamage()
        {
            return damage;
        }

        public int calculateDamage()
        {
            return getDamage() * Number;
        }

        public string toString()
        {
            return "The alien " + Name + " with health " + Health +
                " caused " + calculateDamage() + " damage.";
        }
    }

    public class OgreAlien : Alien
    {
        public int damage = 6;
        public int Number { get; set; }

        public OgreAlien(int health, string name, int number) : base(health, name)
        {
            Number = number;
            Health = health;
            Name = name;
        }

        public int getDamage()
        {
            return damage;
        }

        public int calculateDamage()
        {
            return getDamage() * Number;
        }

        public string toString()
        {
            return "The alien " + Name + " with health " + Health +
                " caused " + calculateDamage() + " damage.";
        }
    }

    public class MarshallowManAlien : Alien
    {
        public int damage = 1;
        public int Number { get; set; }

        public MarshallowManAlien(int health, string name, int number) : base(health, name)
        {
            Number = number;
            Health = health;
            Name = name;
        }

        public int getDamage()
        {
            return damage;
        }

        public int calculateDamage()
        {
            return getDamage() * Number;
        }

        public string toString()
        {
            return "The alien " + Name + " with health " + Health +
                " caused " + calculateDamage() + " damage.";
        }
    }
}