namespace Polimorphism;

public class Food
{
    public string Name { get; set; }
    public virtual void Offer()
    {
        Console.WriteLine($"{Name} is offered with rice!");
    }
}

public class Baklava : Food 
{
    public override void Offer()
    {
        Console.WriteLine($"{Name} is offered with ice-cream!");
    }
}
public class HoricotBean : Food 
{

}