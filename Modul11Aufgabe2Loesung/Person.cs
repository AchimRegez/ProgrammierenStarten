using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe2Loesung
{
    class Person
    {
        private ILogger logger = new ConsoleLogger();   // Durch Interface wechsel zu Klasse OutputLogger möglich


        private string name;
        public string Name
        {
            get
            {
                logger.Log("Getter von Name wurde aufgerufen!");
                return name;
            }
            set
            {
                logger.Log("Setter von Name wurde aufgerugen!");
                name = value;
            }
        }
    }
}
