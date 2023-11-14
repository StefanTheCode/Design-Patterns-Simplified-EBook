namespace Observer.Station;
using IObserver = Observer.Observers.IObserver;

// Concrete weather station class
public class WeatherStation : IWeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private string weatherUpdate;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(weatherUpdate);

            //Simulation
            Thread.Sleep(1000);
        }
    }

    public void SetWeatherUpdate(string update)
    {
        weatherUpdate = update;
        NotifyObservers();
    }
}
