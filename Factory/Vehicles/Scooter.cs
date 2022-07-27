namespace Factory.Vehicles;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class Scooter : IVehicle
{
    public void Drive(int km)
    {
        Console.WriteLine("Drive the Scooter : " + km + "km");
    }
}