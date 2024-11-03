using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!!
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /*
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *
             * Set the properties values with object initializer syntax
             */

            // Create 4 instances: 1 Car, 1 Motorcycle, and 2 instances of type Vehicle but from derived classes
            Car myFirstCar = new Car
            {
                Year = "2022",
                Make = "Toyota",
                Model = "Camry",
                HasTrunk = true
            };

            Motorcycle myFirstBike = new Motorcycle
            {
                Year = "2023",
                Make = "Harley-Davidson",
                Model = "Sportster",
                HasSideCart = false
            };

            Vehicle mySecondCar = new Car
            {
                Year = "2019",
                Make = "Honda",
                Model = "Accord",
                HasTrunk = true
            };

            Vehicle mySecondBike = new Motorcycle
            {
                Year = "2021",
                Make = "Ducati",
                Model = "Panigale",
                HasSideCart = false
            };

            /*
             * Add the 4 vehicles to the list

            vehicles.Add(myFirstCar)
            vehicles.Add(myFirstBike)
            vehicles.Add(mySecondCar)
            vehicles.Add(mySecondBike)

             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Car Make: {vehicle.Make}, Car Model: {vehicle.Model}, Car Year: {vehicle.Year}");
            };

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("Calling Drive methods for Car:");
            myFirstCar.DriveAbstract();
            mySecondCar.DriveVirtual();  // Uses base class method

            Console.WriteLine("\nCalling Drive methods for Motorcycle:");
            myFirstBike.DriveAbstract();
            mySecondBike.DriveVirtual();  // Uses overridden method

            #endregion
            Console.ReadLine();
        }
    }
}
