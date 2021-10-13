using System;

namespace Modul11Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();
            bmw.Manufacturer = "BMW";
            bmw.MaxSpeed = 300;

            ElectricCar tesla = new ElectricCar();
            tesla.Manufacturer = "Tesla";
            tesla.MaxSpeed = 250;

            Motorbike ducati = new Motorbike();
            ducati.Manufacturer = "Ducati";
            ducati.MaxSpeed = 200;

            IMotorVehicle[] vehicles = new IMotorVehicle[3];
            vehicles[0] = bmw;
            vehicles[1] = tesla;
            vehicles[2] = ducati;

            foreach(IMotorVehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Manufacturer);
                Console.WriteLine(vehicle.MaxSpeed);
                vehicle.Drive();
                vehicle.Brake();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
