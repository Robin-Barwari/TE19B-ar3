using System;

namespace Labb_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många sidor ska tärningen ha?");
            int antalSidor = int.Parse(Console.ReadLine());

            Tärning tärning = new Tärning(antalSidor);

            tärning.SkrivUt();
        }
    }
}
