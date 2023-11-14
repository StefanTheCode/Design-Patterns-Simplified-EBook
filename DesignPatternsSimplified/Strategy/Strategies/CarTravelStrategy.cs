namespace Strategy.Strategies;

// Concrete strategy classes for different modes of transportation
public class CarTravelStrategy : ITravelStrategy
{
    public void Travel(string source, string destination)
    {
        Console.WriteLine($"Traveling by car from {source} to {destination}");
    }
}
