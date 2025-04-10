using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHandling
{
    //Del 2, med tanke på mängden filer och hur små dessa klasser är valde jag att behålla dom i samma fil.
    abstract class SystemError
    {
        public abstract string ErrorMessage();
    }
    class EngineFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Engine failure: Check engine status!";
        }
    }
    class BrakeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Brake failure: Vehicle is unsafe to drive!";
        }
    }
    class TransmissionError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Transmission failure: Repairs needed!";
        }
    }
}
