namespace Factory.Vehicles;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class Bike : IVehicle
{
    public void Drive(int km)
    {
        Console.WriteLine("Drive the Bike : " + km + "km");
    }
}