namespace gyakorlas5;

public class Library
{
    public List<Borrow> BorrowedItems { get; set; }
    public List<Item> Items { get; set; }
    
    public Library(List<Borrow> borrowedItems, List<Item> items)
    {
        BorrowedItems = borrowedItems;
        Items = items;
    }

    public Item? BorrowItem(uint id, User user)
    {
        if (Items.FindAll(x => x.Id == id).Count > 0)
        {
            if (BorrowedItems.FindAll(x => x.User.Id == user.Id && x.ReturnDate == null).Count < user.BorrowCapacity())
            {
                Borrow borrowedItem = new Borrow(DateTime.Now, user, Items.Where(x => x.Id == id).First());
                BorrowedItems.Add(borrowedItem);
                
                Items.Remove(Items.Where(x => x.Id == id).First());
                return BorrowedItems.Where(x => x.Item.Id == id).First().Item;
            }
            else
            {
                
                Console.WriteLine("Too much borrowed items.");
                return null;
            }
        }
        else
        {
            Console.WriteLine("Item is not found.");
            return null;
        }

        return null;
    }

    public void ReturnItem(Item item, User user)
    {
        if (BorrowedItems.Where(x => x.Item.Id == item.Id && x.ReturnDate == null).Count() != 0)
        {
            BorrowedItems.Where(x => x.Item.Id == item.Id).First().ReturnDate = DateTime.Now;
            Items.Add(item);
        }
    }
}