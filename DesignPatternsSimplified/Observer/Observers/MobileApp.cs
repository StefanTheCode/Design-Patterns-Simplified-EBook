namespace Observer.Observers;

// Concrete weather device classes (observers)
public class MobileApp : IObserver
{
    private string deviceName;

    public MobileApp(string name)
    {
        deviceName = name;
    }

    public void Update(string update)
    {
        Console.WriteLine($"Mobile App '{deviceName}' received weather update: {update}");
    }
}