using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12AbstrkteKlassen
{
    class MechatronicsEngineer : Workers
    {
        public MechatronicsEngineer(string name, decimal salary) : base(name, salary)
        {

        }

        public override void DoWork()
        {
            Console.WriteLine("Der Mechatroniker {0} betritt die Werkstatt...", Name);
            Console.WriteLine("{0} arbeitet dort mit Autos...", Name);
        }
    }
}
