using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE:  TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE:  Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE:   Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE: Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE: In each of your car, truck, and suv classes

            /*DONE: Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car mycar = new Car() { IsAutomatic = "Automatic", HasRadio = "Satellite", HasSeats = "Bucket", HasWheels = "Alloy", HasWipers = "Bosch", ManufacturerWarranty = 100000, Logo = "Ford", TrunkSize = "Large" };
            Console.WriteLine("What did you car come with when you purchased it?");
            Console.WriteLine("-----------------------------------------------------------------------\n");
            Console.WriteLine($"My Ford Taurus has the {mycar.Logo} logo on the front, it comes with {mycar.HasRadio} with 150 Channels\n");
            Console.WriteLine($"It also has {mycar.HasSeats} seats and {mycar.HasWheels} wheels. It has plenty of storage space  with {mycar.TrunkSize} trunk size.");
            Console.WriteLine($"and has a {mycar.IsAutomatic} transmission.\n");
            Console.WriteLine($"The {mycar.HasWipers} wipers make driving safe in the rain. It also has a 4 year, {mycar.ManufacturerWarranty} mile warranty");
            Console.WriteLine("---------------------------------------------------------------------------\n");
            Console.WriteLine();

            Truck truck1 = new Truck() { HasTowPackage = "Heavy Duty", HasRadio = "Satellite", HasSeats = "Heated", HasWheels = "Chrome", HasWipers = "WeatherTech", ManufacturerWarranty = 100000, Logo = "Chevy", BedSize = "Large"};
            Console.WriteLine("What features does Cheverolet Trucks Come with?");
            Console.WriteLine("-----------------------------------------------------------------------\n");
            Console.WriteLine($"My Chevy Silverado has the {truck1.Logo} logo on the front, it comes with {truck1.HasRadio} with 150 Channels\n");
            Console.WriteLine($"It also has {truck1.HasSeats} seats and {truck1.HasWheels} wheels. It has plenty of storage space with {truck1.BedSize} bed size,");
            Console.WriteLine($"and has a {truck1.HasTowPackage} tow package.\n");
            Console.WriteLine($"The {truck1.HasWipers} wipers make driving safe in the rain. It also has a 4 year, {truck1.ManufacturerWarranty} mile warranty");
            Console.WriteLine("---------------------------------------------------------------------------\n");
            Console.WriteLine();

            SUV suv1 = new SUV() { Logo = "GMC", CargoSize = "Medium", AutoRunningBoards = "Activate on Start", HasRadio = "Satellite", HasSeats = "Leather and Heated", HasWheels = "Chrome", ManufacturerWarranty = 100000 };
            Console.WriteLine("Tell me bout the GMC Yukon Denali?");
            Console.WriteLine("-----------------------------------------------------------------------\n");
            Console.WriteLine($"My Chevy Silverado has the {suv1.Logo} logo on the front, it comes with {suv1.HasRadio} with 150 Channels\n");
            Console.WriteLine($"It also has {suv1.HasSeats} seats and {suv1.HasWheels} wheels. It has plenty of storage space with {suv1.CargoSize} cargo size,\n");
            Console.WriteLine($"The Running Borads {suv1.AutoRunningBoards} for convenience.\n");
            Console.WriteLine($"The {truck1.HasWipers} wipers make driving safe in the rain. It also has a 4 year, {truck1.ManufacturerWarranty} mile warranty");
            Console.WriteLine("---------------------------------------------------------------------------\n");
            Console.WriteLine();

        }
    }
}
