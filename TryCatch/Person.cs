using System;

namespace TryCatch
{
    public class Person
    {
        private string förnamna;
        private string efternamn;
    
        public string Förnamn 
        { 
            get
            {
                return Förnamn;

            }

            set
            {
                // Börjar det med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Förnamn måste börja med en versal!");
                }
                // Är förnamnet minst 4 tecken långt
                else if(value.Length < 4)
                {
                    throw new ArgumentException("Förnman måste vara minst 4 tecken långt");
                }
                else
                {
                    förnamna = value;
                }
            }
        }
        public string Efternamn 
        { 
            get
            {
                return Efternamn;

            }

            set
            {
                // Börjar det med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Efternamn måste börja med en versal!");
                }

                // Är förnamnet minst 3 tecken långt
                else if(value.Length < 3)
                {
                    throw new ArgumentException("Efternamn måste vara minst 3 tecken långt");
                }
                else
                {
                    efternamn = value;
                }
            }
        }

        public Person(string förnamn, string efternamn)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
        }
    }
}