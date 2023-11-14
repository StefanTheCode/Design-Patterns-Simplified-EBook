using FactoryMethod.Concrete;

namespace FactoryMethod.Factory;

// Concrete BMW factory class
public class BMWFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new BMWCar();
    }
}