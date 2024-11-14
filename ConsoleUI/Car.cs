using System;
using ConsoleUI;
// Non-abstract class Car that inherits from Vehicle
public class Car : Vehicle
{
    // Distinct property for Car
    public bool HasTrunk { get; set; } = true;

    // Implementing the abstract method
    public override void DriveAbstract()
    {
        Console.WriteLine("The car is being driven (Abstract implementation for Car).");
    }
}
