using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {

        }

        public string TrunkSize { get; set; }
        public string IsAutomatic { get; set; }
        public string HasWheels { get; set ; }
        public string HasRadio { get ; set ; }
        public string HasSeats { get; set; }
        public string HasWipers { get; set; }
        public int ManufacturerWarranty { get; set; }
        public string Logo { get; set; }
    }
}
