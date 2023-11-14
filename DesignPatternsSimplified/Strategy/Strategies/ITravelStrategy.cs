namespace Strategy.Strategies;

// Strategy interface representing a mode of transportation
public interface ITravelStrategy
{
    void Travel(string source, string destination);
}
