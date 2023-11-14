using Strategy.Strategies;

namespace Strategy;

// Context class that uses a travel strategy
public class TravelPlanner
{
    private ITravelStrategy travelStrategy;

    public void SetTravelStrategy(ITravelStrategy strategy)
    {
        travelStrategy = strategy;
    }

    public void PlanTravel(string source, string destination)
    {
        if (travelStrategy != null)
        {
            travelStrategy.Travel(source, destination);
        }
        else
        {
            Console.WriteLine("Please select a travel strategy.");
        }
    }
}