using Bridge.Content;

namespace Bridge.Books;

// Refined Abstraction: Science book
public class ScienceBook : Book
{
    public ScienceBook(IBookContent content) : base(content)
    {
    }

    public override void Produce()
    {
        Console.Write("Science book ");
        bookContent.CreateContent();
    }
}
