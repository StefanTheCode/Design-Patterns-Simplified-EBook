using Decorator.Coffee;

namespace Decorator.Decorators;

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} + Chocolate";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 1.0;
    }
}