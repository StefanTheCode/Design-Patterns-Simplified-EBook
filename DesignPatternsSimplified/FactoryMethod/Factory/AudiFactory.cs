using FactoryMethod.Concrete;

namespace FactoryMethod.Factory;

// Concrete Audi factory class
public class AudiFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new AudiCar();
    }
}