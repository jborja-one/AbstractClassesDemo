// Non-abstract class Motorcycle that inherits from Vehicle
public class Motorcycle : Vehicle
{
    // Distinct property for Motorcycle
    public bool HasSideCart { get; set; } = false;

    // Implementing the abstract method
    public override void DriveAbstract()
    {
        Console.WriteLine("The motorcycle is being driven (Abstract implementation for Motorcycle).");
    }

    // Overriding the virtual method
    public override void DriveVirtual()
    {
        Console.WriteLine("The motorcycle is being driven (Overridden virtual implementation for Motorcycle).");
    }
}
