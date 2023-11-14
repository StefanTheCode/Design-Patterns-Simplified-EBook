namespace Observer.Observers;

public class OutdoorDisplay : IObserver
{
    public void Update(string update)
    {
        Console.WriteLine($"Outdoor Display received weather update: {update}");
    }
}