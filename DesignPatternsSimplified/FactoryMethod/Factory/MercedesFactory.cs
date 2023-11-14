using FactoryMethod.Concrete;

namespace FactoryMethod.Factory;

// Concrete Mercedes factory class
public class MercedesFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new MercedesCar();
    }
}