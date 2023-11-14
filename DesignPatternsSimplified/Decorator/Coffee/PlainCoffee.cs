namespace Decorator.Coffee;

// Concrete component representing plain coffee
public class PlainCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Plain Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}