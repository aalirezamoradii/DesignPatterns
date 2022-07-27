namespace Factory;

public static class Program
{
    private static void Main()
    {
        VehicleFactory factory = new ConcreteVehicleFactory();

        var scooter = factory.GetVehicle("Scooter");
        scooter.Drive(10);

        var bike = factory.GetVehicle("Bike");
        bike.Drive(20);

        Console.ReadKey();
    }
}