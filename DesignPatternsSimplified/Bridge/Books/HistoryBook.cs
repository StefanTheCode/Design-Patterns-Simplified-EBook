using Bridge.Content;

namespace Bridge.Books;

// Refined Abstraction: History book
public class HistoryBook : Book
{
    public HistoryBook(IBookContent content) : base(content)
    {
    }

    public override void Produce()
    {
        Console.Write("History book ");
        bookContent.CreateContent();
    }
}