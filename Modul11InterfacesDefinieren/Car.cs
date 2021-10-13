using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Interfaces
{
    class Car : IMotorVehicle
    {
        public string Manufacturer { get; set; }
        public int MaxSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("Das Auto fährt....");
        }

        public void Brake()
        {
            Console.WriteLine("Das Auto bremst....");
        }
    }
}
