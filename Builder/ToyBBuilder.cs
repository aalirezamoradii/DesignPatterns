namespace Builder;

public class ToyBBuilder : IToyBuilder
{
    private readonly Toy _toy = new();

    public void SetModel()
    {
        _toy.Model = "Machine";
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
        _toy.Body = "Steel";
    }
    
    public void SetLegs()
    {
        _toy.Legs = "4";
    }
    
    public Toy GetToy()
    {
        return _toy;
    }
}