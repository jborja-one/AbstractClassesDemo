using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    // Properties with default values
    public string Year { get; set; } = "Unknown Year";
    public string Make { get; set; } = "Generic Make";
    public string Model { get; set; } = "Generic Model";

    // Abstract method, must be implemented by derived classes
    public abstract void DriveAbstract();

    // Virtual method with base implementation
    public virtual void DriveVirtual()
    {
        Console.WriteLine("This is the base DriveVirtual implementation from the Vehicle class.");
    }
}
