namespace Builder;

public class Toy
{
    public string Model { get; set; } = null!;
    public string Head { get; set; } = null!;
    public string Limbs { get; set; } = null!;
    public string Body { get; set; } = null!;
    public string Legs { get; set; } = null!;

    public void WriteConsole()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Head : {Head}");
        Console.WriteLine($"Limbs: {Limbs}");
        Console.WriteLine($"Body : {Body}");
        Console.WriteLine($"Legs : {Legs}");
    }
}