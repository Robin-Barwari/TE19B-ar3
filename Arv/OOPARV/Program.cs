using System;

namespace OOPARV
{
    class Program
    {
        class Creature
        {
            public int Power { get; set; }
            public int Toughness { get; set; }
        }
        class Knight : Creature
        {
            public Knight()
            {
                Power = 5;
                Toughness = 5;
            }

            public void Attack()
            {
                Console.WriteLine("Knight attack with power " + Power);
            }
        }
        class Wizard : Creature
        {
            public Wizard()
            {
                Power = 7;
                Toughness = 3;
            }

            public void Attack()
            {
                Console.WriteLine("Wizard attack with power" + Power);
            }
            static void Main(string[] args)
            {
                var wizard = new Wizard();
                var knight = new Knight();
                wizard.Attack();
                knight.Attack();

                Console.ReadKey();
            }
        }
    }
}
