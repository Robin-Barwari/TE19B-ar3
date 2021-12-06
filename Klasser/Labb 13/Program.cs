using System;
using System.Collections.Generic;

namespace Labb_13
{
    class Namn
    {
        // "Variabler" för att lagra data
        public string Förnamn { get; set; } // Skydda variabeln
        public string Efternamn { get; set; } // Skydda variabel

        public void VisaNamn()
        {
            Console.WriteLine($"{Förnamn} + {Efternamn}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Namn> lista = new List<Namn>();
            while (true)
            {
                Namn objekt = new Namn();

                Console.WriteLine("Ange ditt förnamn: ");
                objekt.Förnamn = Console.ReadLine();


                if (objekt.Förnamn == "")
                {
                    break;
                }
                Console.WriteLine("Ange ditt Efternamn");
            }
        }
    }
}