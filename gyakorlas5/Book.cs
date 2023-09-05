namespace gyakorlas5;

public class Book
{
    public uint NumberOfPages { get; init; }
    public BookType BookType { get; init; }

    public Book(uint numberOfPages, BookType bookType)
    {
        NumberOfPages = numberOfPages;
        BookType = bookType;
    }
}