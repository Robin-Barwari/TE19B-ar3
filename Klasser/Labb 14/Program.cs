using System;

namespace Labb_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Vad heter boken? ");
            string titel = Console.ReadLine();
            Console.WriteLine("Vad heter författaren? ");
            string författare = Console.ReadLine();
            Console.WriteLine("Ange antal sidor ");
            int antalSidor = int.Parse(Console.ReadLine());

            // Skapa ett objekt = bok av typen Bok
            // bok heter också instans av Bok
            // Skapa och ge värdena samtidigt!
            Bok bok = new Bok(titel, författare, antalSidor);

            // Skriv ut sammanfattning
            bok.skrivut();
        }
    }
}
