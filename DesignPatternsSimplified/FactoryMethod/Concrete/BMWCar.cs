namespace FactoryMethod.Concrete;

// Concrete BMW car class
public class BMWCar : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling a BMW car.");

        // Add BMW-specific assembly logic here
    }
}