using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe1Loesung
{
    class Katze : ITier
    {
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        public Katze(string geschlecht, int alter)
        {
            Geschlecht = geschlecht;
            Alter = alter;
        }

        public void Fressen()
        {
            Console.WriteLine("Die Katze frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Die Katze trinkt!");
        }
    }
}
