using Factory.Vehicles;

namespace Factory;

/// <summary>
/// The Creator Abstract Class
/// </summary>
public abstract class VehicleFactory
{
    public abstract IVehicle GetVehicle(string vehicle);
}