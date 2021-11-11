using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public string BedSize { get; set; }

        public string HasTowPackage { get; set; }
        public string HasWheels { get ; set ; }
        public string HasRadio { get ; set ; }
        public string HasSeats { get ; set ; }
        public string HasWipers { get ; set; }
        public int ManufacturerWarranty { get ; set ; }
        public string Logo { get ; set ; }
    }
}
