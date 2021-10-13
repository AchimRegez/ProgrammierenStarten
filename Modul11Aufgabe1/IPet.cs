using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe1
{
    interface IPet
    {
        string Gender { get; set; }
        int Age { get; set; }

        void Eat();

        void Drink();
    }
}
