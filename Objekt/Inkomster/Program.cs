using System;
using System.Collections.Generic;

namespace Inkomster
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
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
                Console.WriteLine("Ange ditt namn: (Enter avbryter)");
                objekt.Namn = Console.ReadLine();

                // Avbryt om namn är tomt
                if (objekt.Namn == "")
                {
                    break;
                }

                Console.WriteLine("Ange din månadslön: ");
                objekt.Lön = ReadInt();

                // Lägg in i listan
                lista.Add(objekt);
            }


        }
        static int ReadInt()
        {
            int månadslön;
            while (!int.TryParse(Console.ReadLine(), out månadslön))
            {
                Console.WriteLine("Ange bara heltal. Försök igen.");
            }
            return månadslön;
        }
    }
}
