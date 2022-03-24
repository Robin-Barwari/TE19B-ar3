using System;
using System.Linq;

namespace TryCatch
{
    public class Arbetare : Person
    {
        // Skyddade interna variabler
        private int lön;
        private int antalTimmar;

        // Tillgängliga metoder för att läsa och ädra ovan variablernas värde
        public int Lön
        {
            get
            {
                return lön;
            }
            // Här ska vi kolla ifall användaren matar in rimilig data
            set
            {
                if (value >= 0 && value <= 20000)
                {
                    lön = value;
                }
                else
                {
                    throw new ArgumentException("Lön måste vara mellan 0 och 20 000 kr.");
                }
            }
        }
        public int AntalTimmar
        {
            get
            {
                return antalTimmar;
            }
            // Här ska vi kolla ifall användaren matar in rimilig data
            set
            {
                if (value >= 0 && value <= 50)
                {
                    antalTimmar = value;
                }
                else
                {
                    throw new ArgumentException("Antal timmar måste vara mellan 0 och 50 timmar.");
                }
            }
        }
        // Konstruktor för att sätta variablerna vid skapelsen av instansen
        public Arbetare(string förnamn, string efternamn, string lön, string antalTimmar) : base(förnamn, efternamn)
        {
            // Omvandla string till tal
            // Går det inte, kasta en exception
            int resultat = 0;
            if (!int.TryParse(lön, out resultat))
            {
                throw new ArgumentException("Lön måste vara ett heltal");
            }
            else
            {
                Lön = resultat;
            }


            if (!int.TryParse(antalTimmar, out resultat))
            {
                throw new ArgumentException("Antal timmar måste vara ett heltal");
            }
            else
            {
                AntalTimmar = resultat;
            }
        }

        // func
        public float RäknaTimlön()
        {
            return lön / antalTimmar;
        }

        // public override string Sammanfattning()
        // {
        //     return "";
        // }
    }
}