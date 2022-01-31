using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Biluthyrning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");

            // Skapa ett första avtal
            Avtal avtal1 = new Avtal();

            Console.WriteLine("Ange kundens personnr: ");
                avtal1.Personnr = Console.ReadLine();

            Console.WriteLine("Ange bilens regnr: ");
                avtal1.RegNr = Console.ReadLine();

            Console.WriteLine("Ange antal km: ");
                avtal1.Km = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange antal dygn: ");
                avtal1.Tidsram = int.Parse(Console.ReadLine());
            
            avtal1.Datum = DateTime.Today;

            // Räkna ut total kostnaden
            Console.WriteLine($"Total hyran blir {avtal1.RäknaKostnad()}:-");
            Console.WriteLine($"Total hyran blir {avtal1.RäknaInlämningsdatum()}");

        }
    }

    class Avtal
    {
        public DateTime Datum {get; set;}
        public string RegNr {get; set;}
        public int Km {get; set;}
        public int Kostnad {get; set;}
        public int Tidsram {get; set;}
        public string Personnr {get; set;}

        // Privat variabler som bara ska användas inuti klassen
        public IDictionary<string, int> bilar = new Dictionary<string, int>
        {
            {"ABC123", 500},
            {"DEF123", 400},
            {"GHI123", 199}
        };

        public float RäknaKostnad()
        {
            // @todo inte krascha om regnr inte finns
            // @todo 100 km ingår i hyran, bara betala för extra km
            Kostnad = bilar[RegNr] * Tidsram + Km * 2;
            return Kostnad;
        }

        public string RäknaInlämningsdatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd MMMM yyyy");
        }
    }
}
