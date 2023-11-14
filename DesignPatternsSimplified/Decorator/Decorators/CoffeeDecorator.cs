using Decorator.Coffee;

namespace Decorator.Decorators;

// Decorator abstract class
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return coffee.GetCost();
    }
}