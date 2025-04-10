using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{   
    //Abstrakt vehicle-klass enligt Del 3
    //TODO: Move to new solution folder vehicles or something
    abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        //Get-Set metoder för properties
        public string Brand 
        { 
            get 
            { 
                return brand; 
            } 
            set 
            { 
                if (value.Length < 2 || value.Length > 20) 
                    throw new ArgumentException("Brand must be between 2 and 20 characters long."); 
                else 
                    brand = value; 
            } 
        }
        public string Model 
        { 
            get 
            { 
                return model; 
            } 
            set 
            { 
                if (value.Length < 2 || value.Length > 20) 
                    throw new ArgumentException("Model must be between 2 and 20 characters long.");
                else 
                    model = value; 
            } 
        }
        public int Year 
        { 
            get 
            { 
                return year; 
            } 
            set 
            { 
                if (value < 1886 || value > DateTime.Today.Year) 
                    throw new ArgumentException("Year cannot be older than 1886 or newer than current year."); 
                else 
                    year = value; 
            } 
        }
        public double Weight 
        { 
            get 
            { 
                return weight; 
            } 
            set 
            { 
                if (value < 0.0) 
                    throw new ArgumentException("Weight must be a positive value"); 
                else 
                    weight = value; 
            } 
        }
        //Slut på Get-Set metoder för properties

        //Virtual metod StartEngine, som fallback om nytt fordon inte implementerar en StartEngine metod.
        //Kan i dagsläget vara en abstract egentligen då alla fordon implementerar den, osäker på vad best practice är.
        public virtual void StartEngine()
        { 
            Console.WriteLine("The vehicle's engine is on."); 
        }
        //Virtual metod Stats som används av ListVehicles() i VehicleHandler, som fallback om nytt fordon inte implementerar en StartEngine metod.
        //Kan i dagsläget vara en abstract egentligen då alla fordon implementerar den, osäker på vad best practice är.
        public virtual void Stats()
        {
            Console.WriteLine($"{this.Brand} {this.Model}, {this.Year}, {this.Weight}kg");
        }
    }
}
