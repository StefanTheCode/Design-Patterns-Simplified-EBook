namespace Adapter;

// Adapter class that adapts the European charger to the UK socket
public class EUToUKAdapter : IUKSocket
{
    private EuropeanCharger europeanCharger;

    public EUToUKAdapter(EuropeanCharger charger)
    {
        europeanCharger = charger;
    }

    public void PlugIntoUKSocket()
    {
        Console.WriteLine("Using adapter to plug into UK socket.");
        europeanCharger.PlugIntoEUSocket();
    }
}