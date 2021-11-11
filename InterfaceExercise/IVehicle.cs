using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string HasWheels{ get; set; }
        public string HasRadio { get; set; }
        public string HasSeats { get; set; }
        public string HasWipers { get; set; }
    }
}
