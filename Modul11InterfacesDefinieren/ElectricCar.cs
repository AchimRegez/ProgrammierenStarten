using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Interfaces
{
    class ElectricCar : IMotorVehicle
    {
        public string Manufacturer { get; set; }
        public int MaxSpeed { get; set; }

        public void Brake()
        {
            Console.WriteLine("Das Elektro-Auto bremst....");
        }

        public void Drive()
        {
            Console.WriteLine("Das Elektro-Auto fährt....");
        }
    }
}
