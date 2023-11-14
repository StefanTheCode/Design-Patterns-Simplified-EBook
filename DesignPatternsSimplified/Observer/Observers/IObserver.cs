namespace Observer.Observers;

// Observer interface representing weather devices
public interface IObserver
{
    void Update(string update);
}