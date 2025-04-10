namespace VehicleHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            VehicleHandler vehicleHandler = new VehicleHandler();
            try
            {
                vehicleHandler.AddVehicle("Ford", "Mustang", 2025, 2200.0);
                vehicleHandler.AddVehicle("Fiat", "Punto", 2012, 2.0);
                vehicleHandler.AddVehicle("Volvo", "V-70", 2018, 1900.0);
                vehicleHandler.AddVehicle("Saab", "900", 1998, 1400.0);
                vehicleHandler.AddVehicle("Toyota", "Prius", 2019, 1600.0);
                vehicleHandler.AddVehicle("Peguot", "406", 2004, 900.0);
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e); 
            }
            vehicleHandler.ListVehicles();
        }
    }
}
