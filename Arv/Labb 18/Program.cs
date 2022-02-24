using System;

namespace Labb_18
{
    public class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }
        protected string Name { get; set; }

        public Creature(string name)
        {
            Name = name;
        }

        public string GetInfo()
        {
            return "";
        }
    }
    public class Knight : Creature
    {
        protected string Weapon { get; set; }
        public Knight(string name, string weapon) : base(name)
        {
            Weapon = weapon;
        }
    }

    public class Dragon : Creature
    {
        protected string Color { get; set; }
        public Dragon(string name, string color) : base(name)
        {
            Color = color;
        }

        public void Attack()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
