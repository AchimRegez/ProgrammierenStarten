using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12VirtuelleMethoden
{
    class Electrician : Workers
    {
        public Electrician(string name, decimal salary) : base(name, salary)
        {

        }

        public override void DoWork()
        {
            Console.WriteLine("Der Elektriker {0} betritt die Baustelle...", Name);
            Console.WriteLine("{0} zieht heute Kabel ein...", Name);
        }

        public override string ToString()
        {
            return "Es handelt sich um einen Handwerker... Sein Name ist: " + Name;
        }
    }
}
