/** Frågor:
 *  Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
 *      Kompileringsfel, vi går ifrån typsäkerhet. Ungefär som att försöka göra en int number = "Hello World".
 *      
 *  Vilken typ bör en lista vara för att rymma alla fordonstyper?
 *      Listan bör vara av typen vehicle, eftersom vehicle är bastypen.
 *  
 *  Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
 *      Typ, eftersom jag loopar igenom listan med vehicles, så måste jag först kolla om vehicle-objektet är ICleanable (vehicle is ICleanable).
 *      Efter det kan jag casta om det till en ICleanable istället för ett vehicle, och sedan använda Clean().
 *      Utan en check och att casta om går det inte, då vehicle i sig inte implementerar ICleanable.
 * 
 *  Vad är fördelarna med att använda ett interface här istället för arv?
 *      Eftersom vi enbart kan ärva från en basklass, så skulle vi förlora typen "vehicle", och inte kunna sparas i samma lista som andra objekt av typen vehicle.
 *      Eftersom vi kan implementera hur många interfaces som helst, så kan vi skapa vehicles som alla går i samma typ-säkra lista men med många olika delade funktioner.
 * **/

namespace VehicleHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Del 1, testar valideringar i vehicle.
            VehicleHandler vehicleHandler = new VehicleHandler();

            try { vehicleHandler.AddCar("F", "Mustang", 2025, 1778.082, 5); }
            catch (Exception e) { Console.WriteLine(e); Console.WriteLine(); }
            try { vehicleHandler.AddCar("Ford", "M", 2025, 1778.082, 5); }
            catch (Exception e) { Console.WriteLine(e); Console.WriteLine(); }
            try { vehicleHandler.AddCar("Ford", "Mustang", DateTime.Now.Year + 1, 1778.082, 5); }
            catch (Exception e) { Console.WriteLine(e); Console.WriteLine(); }
            try { vehicleHandler.AddCar("Ford", "Mustang", 2025, -1.0, 5); }
            catch (Exception e) { Console.WriteLine(e); Console.WriteLine(); }
            //För skojs skull, testar validering för specifikt Car-attribut (seater)
            try { vehicleHandler.AddCar("Ford", "Mustang", 2025, 1778.082, 0); }
            catch (Exception e) { Console.WriteLine(e); Console.WriteLine(); }

            //Del 2, skapa en lista med alla error-objekt och skriv ut samtliga. Då klasserna var så små skrev jag allt i SystemError.cs för att minska antalet filer.

            List<SystemError> errorMessages = new List<SystemError>();
            errorMessages.Add(new EngineFailureError());
            errorMessages.Add(new BrakeFailureError());
            errorMessages.Add(new TransmissionError());

            foreach (SystemError error in errorMessages)
            { 
                Console.WriteLine(error.ErrorMessage());
            }
            Console.WriteLine();

            //Del 4, skapa lista<Vehicle> (redan gjort när vehicleHandler skapades) och fyll med olika fordon. Loopar sedan igenom listan med metod i vehicleHandler.

            try
            {
                vehicleHandler.AddCar("Ford", "Mustang", 2025, 1778.082, 5);
                vehicleHandler.AddTruck("Tesla", "Truck", 2023, 3000.0, 0.0001);
                vehicleHandler.AddMotorcycle("Kawasaki", "Ninja 400", 2018, 168.0, true);
                vehicleHandler.AddElectricScooter("Xiao Mi", "M365", 2019, 8.0, 6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            vehicleHandler.ListVehicles();

            Console.ReadLine();
        }
    }
}
