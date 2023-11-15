using Bridge.Content;

namespace Bridge.Books;

// Refined Abstraction: Math book
public class MathBook : Book
{
    public MathBook(IBookContent content) : base(content)
    {
    }

    public override void Produce()
    {
        Console.Write("Math book ");
        bookContent.CreateContent();
    }
}