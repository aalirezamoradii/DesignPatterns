using Factory.Vehicles;

namespace Factory;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class ConcreteVehicleFactory : VehicleFactory
{
    public override IVehicle GetVehicle(string vehicle)
    {
        return vehicle switch
        {
            "Scooter" => new Scooter(),
            "Bike" => new Bike(),
            _ => throw new ApplicationException($"Vehicle '{vehicle}' cannot be created")
        };
    }
}