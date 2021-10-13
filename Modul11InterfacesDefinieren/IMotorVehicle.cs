using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Interfaces
{
    interface IMotorVehicle
    {
        //Member

        //Properties
        string Manufacturer { get; set; }
        int MaxSpeed { get; set; }

        //Methods
        void Drive();
        void Brake();
    }
}
