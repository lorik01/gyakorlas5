namespace gyakorlas5;

public class Borrow
{
    public DateTime BorrowDate { get; init; }
    public DateTime ReturnDate { get; set; }
    public User User { get; set; }
    public Item Item { get; set; }

    public Borrow(DateTime borrowDate, User user, Item item)
    {
        BorrowDate = borrowDate;
        User = user;
        Item = item;
    }
}