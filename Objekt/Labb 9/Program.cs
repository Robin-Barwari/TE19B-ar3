using System;
using System.Collections.Generic;

namespace Inkomster
{
    class PersonInkomst
    {
        public string Förnamn = "";
        public string Efternamn = "";
        public string NamnAdress = "";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");
            List<PersonInkomst> lista = new List<PersonInkomst>();

            // Upprepa tills användaren skriver tomt
            while (true)
            {
                // Lagra uppgifter i ett objekt
                PersonInkomst objekt = new PersonInkomst();
                
                // Ange namn och lön
                Console.WriteLine("Ange ditt förnamn: (Enter avbryter)");
                objekt.Förnamn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Förnamn == "")
                {
                    break;
                }

                Console.WriteLine("Ange din Efternamn: ");
                objekt.Efternamn = Console.ReadLine();

                Console.WriteLine("Ange gatuadress: ");
                objekt.NamnAdress = Console.ReadLine();
                

                // Lägg in i listan
                lista.Add(objekt);
            }
        }
    }
}