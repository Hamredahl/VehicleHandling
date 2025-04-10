using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        public string Brand 
        { 
            get 
            { 
                return brand; 
            } 
            set 
            { 
                if (value.Length < 2 || value.Length > 20) 
                    throw new ArgumentException("Must be between 2 and 20 characters long."); 
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
                    throw new ArgumentException("Must be between 2 and 20 characters long.");
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
                if (value < 1886 && value > DateTime.Today.Year) 
                    throw new ArgumentException("Cannot be older than 1886 or newer than current year."); 
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
                    throw new ArgumentException("Must be a positive value"); 
                else 
                    weight = value; 
            } 
        }
    }
}
