using Bridge.Books;
using Bridge.Content;

// Creating content for English language
IBookContent englishContent = new EnglishContent();

// Creating different books with English content
Book englishMathBook = new MathBook(englishContent);
Book englishHistoryBook = new HistoryBook(englishContent);
Book englishScienceBook = new ScienceBook(englishContent);

// Producing books with English content
englishMathBook.Produce();
englishHistoryBook.Produce();
englishScienceBook.Produce();

Console.WriteLine();

// Creating content for Spanish language
IBookContent spanishContent = new SpanishContent();

// Creating different books with Spanish content
Book spanishMathBook = new MathBook(spanishContent);
Book spanishHistoryBook = new HistoryBook(spanishContent);
Book spanishScienceBook = new ScienceBook(spanishContent);

// Producing books with Spanish content
spanishMathBook.Produce();
spanishHistoryBook.Produce();
spanishScienceBook.Produce();

Console.WriteLine();

// Creating content for French language
IBookContent frenchContent = new FrenchContent();

// Creating different books with French content
Book frenchMathBook = new MathBook(frenchContent);
Book frenchHistoryBook = new HistoryBook(frenchContent);
Book frenchScienceBook = new ScienceBook(frenchContent);

// Producing books with French content
frenchMathBook.Produce();
frenchHistoryBook.Produce();
frenchScienceBook.Produce();

Console.ReadLine();