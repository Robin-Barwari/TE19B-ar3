using System;

namespace Labb_19
{
    public class Media
    {
        
    }
    public class Bok : Media
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public string AntalSidor { get; set; }

        public Bok(string titel, string författare, string antalSidor)
        {
            Titel = titel;
            Författare = författare;
            AntalSidor = antalSidor;
        }

        public string TillText()
        {
            return($"{Titel} ({Författare} {AntalSidor})");
        }
    }
    public class Film : Media
    {
        public string Titel { get; set; }
        public string Regissör { get; set; }
        public string Längd { get; set; }

        public Film(string titel, string regissör, string längd)
        {
            Titel = titel;
            Regissör = regissör;
            Längd = längd;
        }

        public string TillText()
        {
            return($"{Titel} ({Regissör} {Längd})");
        }
    }
}