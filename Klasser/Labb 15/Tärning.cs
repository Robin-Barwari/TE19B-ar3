using System;

namespace Labb_15
{
    public class Tärning
    {
        private int AntalSidor { get; set;}

        public Tärning(int _antalSidor)
        {
            AntalSidor = _antalSidor;
        }

        public void SkrivUt()
        {
            Random generator = new Random();
            int siffra = generator.Next(1, AntalSidor + 1);
            Console.WriteLine($"Tärningen har {AntalSidor} sidor och du rullade siffran {siffra}");
        }
    }
}