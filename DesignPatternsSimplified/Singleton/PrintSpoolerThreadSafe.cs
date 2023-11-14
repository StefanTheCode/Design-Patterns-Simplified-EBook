namespace Singleton;

public class PrintSpoolerThreadSafe
{
    private static volatile PrintSpoolerThreadSafe instance;
    private static readonly object syncRoot = new object();

    private PrintSpoolerThreadSafe()
    {
    }

    public static PrintSpoolerThreadSafe GetInstance()
    {
        if (instance is null)
        {
            lock (syncRoot)
            {
                if (instance is null)
                {
                    instance = new PrintSpoolerThreadSafe();
                }
            }
        }

        return instance;
    }

    public void Print(string document)
    {
        // Simulate printing logic.
        Console.WriteLine($"Printing: {document}");
    }
}