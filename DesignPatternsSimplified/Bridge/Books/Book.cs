using Bridge.Content;

namespace Bridge.Books;

// Abstraction class for book subjects
public abstract class Book
{
    protected IBookContent bookContent;

    public Book(IBookContent content)
    {
        bookContent = content;
    }

    public abstract void Produce();
}