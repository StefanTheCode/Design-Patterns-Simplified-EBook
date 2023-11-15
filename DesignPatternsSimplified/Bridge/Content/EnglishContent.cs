namespace Bridge.Content;

// Concrete Implementor: English content
public class EnglishContent : IBookContent
{
    public void CreateContent()
    {
        Console.WriteLine("Creating content in English.");
    }
}