using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    class VehicleHandler
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void ListVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Brand} {vehicle.Model}, {vehicle.Year}, {vehicle.Weight}kg");
            }
        }
        public void AddVehicle(string brand, string model, int year, double weight)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Brand = brand;
            vehicle.Model = model;
            vehicle.Year = year;
            vehicle.Weight = weight;
            vehicles.Add(vehicle);
        }
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
