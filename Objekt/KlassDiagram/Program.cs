using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace KlassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut lönekostnad");

            // Loopa ett antal gånger
            List<Personinkomst> listaPerson = new List<Personinkomst>();
            while (true)
            {
                // Skapa objektet person från klassen PersonInkomst
                Personinkomst person = new Personinkomst();

                // Ange namn
                Console.WriteLine("Vad heter den anställde: (tryck 'Enter' för att avsluta programmet.)");
                person.namn = Console.ReadLine();

                // Avslutar om namn ät tomt
                if(person.namn == "")
                {
                    break;
                }

                // Ange timlön
                Console.WriteLine("Den anställdes timlön: ");
                person.timlön = ReadInt();

                // Ange timlön
                Console.WriteLine("Den anställdes arbetstid: ");
                person.timmar = ReadInt();

                // Lagra i lisyan
                listaPerson.Add(person);
            }

            // spara ned som JSON
            string jsonText = JsonConvert.SerializeObject(listaPerson, Formatting.Indented);

            // Spara ned JSON i textfil
            File.WriteAllText(@"personerinkomst.json", jsonText);
        }
        static int ReadInt()
        {
        int heltal;
        while (!int.TryParse(Console.ReadLine(), out heltal))
        {
        Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
        }
        return heltal;
        }
    }
}
