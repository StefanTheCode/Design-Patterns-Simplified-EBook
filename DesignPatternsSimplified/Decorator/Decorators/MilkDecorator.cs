using Decorator.Coffee;

namespace Decorator.Decorators;

// Concrete decorator classes for adding extras
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} + Milk";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 0.5;
    }
}
