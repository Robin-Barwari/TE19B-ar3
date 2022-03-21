using System;
using System.Linq;

namespace TryCatch
{
    public class Student : Person
    {
        private string studieprogram;

        private string Studieprogram
        {
            get
            {
                return studieprogram;
            }
            set
            {
                // Kolla att inmattat studieprogram är: Teknik, It eller Estet
                // if (value.ToLower() != "Teknik" && value.ToLower() != "Estet" && value.ToLower() != "IT")
                string[] lista = {"teknik", "estet", "it"};
                if (!lista.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Ogiltigt studieprogram!");

                }
                studieprogram = value;
            }
        }

        public Student(string förnamn, string efternamn, string studieprogram)
        : base(förnamn, efternamn)
        {
            Studieprogram = studieprogram;
        }
    }
}