namespace Bridge.Content;

// Concrete Implementor: Spanish content
public class SpanishContent : IBookContent
{
    public void CreateContent()
    {
        Console.WriteLine("Creating content in Spanish.");
    }
}