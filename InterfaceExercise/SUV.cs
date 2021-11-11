using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }

        public string CargoSize { get; set; }
        public string AutoRunningBoards { get; set; }
        public string HasWheels { get; set; }
        public string HasRadio { get; set; }
        public string HasSeats { get; set; }
        public string HasWipers { get; set; }
        public int ManufacturerWarranty { get; set; }
        public string Logo { get; set; }
    }
}
