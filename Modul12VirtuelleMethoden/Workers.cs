using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12VirtuelleMethoden
{
    abstract class Workers
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Workers(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Gehalt: {0}", Salary);
        }

        public virtual void DoWork()
        {
            Console.WriteLine("Der Arbeiter verrichtet seine Arbeit...");
        }
    }
}
