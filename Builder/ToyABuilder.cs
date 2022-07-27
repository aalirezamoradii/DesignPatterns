namespace Builder;

public class ToyABuilder : IToyBuilder
{
    private readonly Toy _toy = new();

    public void SetModel()
    {
        _toy.Model = "Bicycle";
    }

    public void SetHead()
    {
        _toy.Head = "1";
    }

    public void SetLimbs()
    {
        _toy.Limbs = "4";
    }

    public void SetBody()
    {
        _toy.Body = "Plastic";
    }

    public void SetLegs()
    {
        _toy.Legs = "2";
    }

    public Toy GetToy()
    {
        return _toy;
    }
}