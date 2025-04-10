using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    class VehicleHandler
    {        
        //Skapar en lista för kommande vehicles
        public List<Vehicle> vehicles = new List<Vehicle>();

        //Metod för att printa ut alla vehicles i listan
        public void ListVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Stats();
                vehicle.StartEngine();
                if (vehicle is ICleanable)
                {
                    ICleanable cleanable = (ICleanable)vehicle;
                    cleanable.Clean();
                }
            }
        }

        //Metod för att lägga till en Car, använder AddVehicle för att Set alla properties som ärvs från vehicles.
        public void AddCar(string brand, string model, int year, double weight, int seats)
        {
            Car car = new Car();
            car.Seats = seats;
            AddVehicle(car, brand, model, year, weight);
        }
        //Metod för att lägga till en Truck, använder AddVehicle för att Set alla properties som ärvs från vehicles.
        public void AddTruck(string brand, string model, int year, double weight, double cargoCapacity)
        {
            Truck truck = new Truck();
            truck.CargoCapacity = cargoCapacity;
            AddVehicle(truck, brand, model, year, weight);
        }
        //Metod för att lägga till en Motorcycle, använder AddVehicle för att Set alla properties som ärvs från vehicles.
        public void AddMotorcycle(string brand, string model, int year, double weight, bool hasSidecar)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.HasSidecar = hasSidecar;
            AddVehicle(motorcycle, brand, model, year, weight);
        }
        //Metod för att lägga till en ElectricScooter, använder AddVehicle för att Set alla properties som ärvs från vehicles.
        public void AddElectricScooter(string brand, string model, int year, double weight, int batteryRange)
        {
            ElectricScooter electricScooter = new ElectricScooter();
            electricScooter.BatteryRange = batteryRange;
            AddVehicle(electricScooter, brand, model, year, weight);
        }
        //Hjälpmetod för att lägga till properties som ärvs från Vehicle
        private void AddVehicle(Vehicle vehicle, string brand, string model, int year, double weight)
        {
            vehicle.Brand = brand;
            vehicle.Model = model;
            vehicle.Year = year;
            vehicle.Weight = weight;
            vehicles.Add(vehicle);
        }

        //Set-metoder enligt Del 1 krav för Vehicle Handler.
        //Används aldrig i koden eftersom AddVehicle tar in argument från start, och ingen annan uppgift ber om att ändra något värde.
        //Kan möjligen användas för att testa validering, men detta görs i dagsläget genom att kalla på add med felaktiga värden.
        public void SetBrand(Vehicle v, string s)
        {
            v.Brand = s;
        }
        public void SetModel(Vehicle v, string s)
        {
            v.Model = s;
        }
        public void SetYear(Vehicle v, int i)
        {
            v.Year = i;
        }
        public void SetWeight(Vehicle v, double d)
        {
            v.Weight = d;
        }
    }
}
