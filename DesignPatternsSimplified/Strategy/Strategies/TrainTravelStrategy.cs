namespace Strategy.Strategies;

public class TrainTravelStrategy : ITravelStrategy
{
    public void Travel(string source, string destination)
    {
        Console.WriteLine($"Traveling by train from {source} to {destination}");
    }
}