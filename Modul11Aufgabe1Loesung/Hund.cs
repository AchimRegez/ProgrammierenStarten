using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe1Loesung
{
    class Hund : ITier
    {
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        public Hund(string geschlecht, int alter)
        {
            Geschlecht = geschlecht;
            Alter = alter;
        }

        public void Fressen()
        {
            Console.WriteLine("Der Hund frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt!");
        }
    }
}
