using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    class Truck : Vehicle, ICleanable
    {
        private double cargoCapacity;

        public double CargoCapacity
        {
            get 
            { 
                return cargoCapacity; 
            }
            set
            {
                if (value < 0.0)
                    throw new ArgumentException("Truck cargo capacity must be a positive value");
                else
                    cargoCapacity = value;
            }
        }
        public override void Stats()
        {
            Console.WriteLine($"{this.Brand} {this.Model}, {this.Year}, {this.Weight}kg, {this.cargoCapacity}kg cargo capacity.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine is on.");
        }

        public void Clean()
        {
            Console.WriteLine("Cleaning the truck, hope you emptied the cargo.");
        }
    }
}
