using System.Linq.Expressions;
using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Kompakt inmatning
                Console.WriteLine("Förnamn Efternamn: ");
                string[] input = Console.ReadLine().Split(" ");
                
                // Kolla att vi fick två textbitar
                if (input.Length == 2)
                {
                    // Lagra i en instans (objekt)
                    Person person = new Person(input[0], input[1]);
                }
                else
                {
                    Console.WriteLine("Du måste mata in förnamn mellanrum efternamn");
                }
            }
            catch(System.Exception)
            {

                throw;
            }
        }

    }
}
