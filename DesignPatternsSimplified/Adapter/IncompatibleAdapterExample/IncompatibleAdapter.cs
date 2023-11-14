namespace Adapter.IncompatibleAdapterExample;

// Incompatible adapter class that cannot adapt the European charger to the UK socket
public class IncompatibleAdapter : IUKSocket
{
    public void PlugIntoUKSocket()
    {
        Console.WriteLine("Incompatible adapter cannot plug into UK socket.");
    }
}