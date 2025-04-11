using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling.VehicleLib
{
    public class Car : Vehicle, ICleanable
    {
        private int seats;

        public int Seats
        {
            get 
            { 
                return seats; 
            }
            set 
            { 
                if (value < 1)
                    throw new ArgumentException("Car must have at least 1 seat.");
                else 
                    seats = value; 
            }
        }
        public override void Stats()
        {
            Console.WriteLine($"{this.Brand} {this.Model}, {this.Year}, {this.Weight}kg, {this.seats} seater.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Car engine is on.");
        }
        public void Clean()
        {
            Console.WriteLine("Cleaning the car, don't forget to close the sunroof.");
        }
    }
}
