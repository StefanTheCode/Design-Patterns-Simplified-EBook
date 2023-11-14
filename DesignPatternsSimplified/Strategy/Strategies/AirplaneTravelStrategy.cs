namespace Strategy.Strategies;

public class AirplaneTravelStrategy : ITravelStrategy
{
    public void Travel(string source, string destination)
    {
        Console.WriteLine($"Traveling by airplane from {source} to {destination}");
    }
}