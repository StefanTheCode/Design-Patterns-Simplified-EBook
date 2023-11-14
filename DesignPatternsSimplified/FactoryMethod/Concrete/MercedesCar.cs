namespace FactoryMethod.Concrete;

// Concrete Mercedes car class
public class MercedesCar : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling a Mercedes car.");

        // Add Mercedes-specific assembly logic here
    }
}