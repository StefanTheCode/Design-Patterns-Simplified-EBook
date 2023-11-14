using Decorator.Coffee;
using Decorator.Decorators;

// Order a plain coffee

ICoffee coffee = new PlainCoffee();
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

// Add milk to the coffee
coffee = new MilkDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

// Add whipped cream
coffee = new WhippedCreamDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

// Add chocolate
coffee = new ChocolateDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

Console.ReadLine();