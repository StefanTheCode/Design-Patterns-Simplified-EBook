namespace Observer.Station;
using IObserver = Observer.Observers.IObserver;

// Subject interface representing the weather station
public interface IWeatherStation
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}