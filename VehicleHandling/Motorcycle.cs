using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    //TODO: Move to new solution folder vehicles or something
    class Motorcycle : Vehicle
    {
        private bool hasSidecar;

        //Eftersom något annat än en bool ger kompileringsfel, görs ingen specifik validering på dess set-metod. 
        public bool HasSidecar { get; set; }
        public override void Stats()
        {
            string sideCar = hasSidecar ? "a" : "no";
            Console.WriteLine($"{this.Brand} {this.Model}, {this.Year}, {this.Weight}kg, has {sideCar} sidecar.");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine is on.");
        }
    }
}
