namespace Bridge.Content;

// Concrete Implementor: French content
public class FrenchContent : IBookContent
{
    public void CreateContent()
    {
        Console.WriteLine("Creating content in French.");
    }
}