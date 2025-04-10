using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    //TODO: Move to new solution folder vehicles or something
    class ElectricScooter : Vehicle
    {
        private int batteryRange;

        public int BatteryRange
        {
            get 
            { 
                return batteryRange; 
            } 
            set 
            { 
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Electric Scooter battery range must be positive value");
                else
                    batteryRange = value;
            }
        }
        public override void Stats()
        {
            Console.WriteLine($"{this.Brand} {this.Model}, {this.Year}, {this.Weight}kg, {this.batteryRange}km per battery charge.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Scooter... engine? The scooter is on at least.");
        }
    }
}
