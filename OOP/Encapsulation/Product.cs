namespace Encapsulation;

public class Product
{
    private double price;

    public void SetPrice(double value)
    {
        if(value > 0) this.price = value;
        throw new ArgumentException($"{value} is unacceptable!");
    }

    public double GetPrice()
    {
        return price;
    }

    private string name;

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    public int Stock { get; set; }


    public bool IsInStock
    {
        get
        {
            return Stock > 50;
        }
    }
}