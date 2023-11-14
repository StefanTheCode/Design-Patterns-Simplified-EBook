namespace Composite;

// Leaf class representing an individual soldier
public class Soldier : IMilitaryUnit
{
    private string name;

    public Soldier(string name)
    {
        this.name = name;
    }

    public void ConductOperation()
    {
        Console.WriteLine($"Soldier {name} is performing a specific task.");
    }

    public override string ToString()
    {
        return $"Soldier({name})";
    }
}