using gyakorlas5;

namespace LibraryTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BorrowItem_ShouldAddItemToBorrowedItems_Test()
    {
        var library = new Library(new List<Borrow>(), new List<Item>());
        var user = new Resident("John", 1);
        var item = new Item(1, "Sample Item");
        library.Items.Add(item);
        
        var borrowedItem = library.BorrowItem(1, user);
        Assert.Multiple(() =>
        {
            Assert.That(borrowedItem, Is.Not.Null);
            Assert.That(library.BorrowedItems.Count, Is.EqualTo(1));
        });
    }

    [Test]
    public void BorrowItem_ShouldNotExceedBorrowCapacity_Test()
    {
        var library = new Library(new List<Borrow>(), new List<Item>());
        var user = new Resident("John", 1);
        
        var item1 = new Item(1, "Item 1");
        var item2 = new Item(2, "Item 2");
        var item3 = new Item(3, "Item 3");
        library.Items.AddRange(new List<Item> { item1, item2, item3 });
        
        var borrowedItem1 = library.BorrowItem(1, user);
        var borrowedItem2 = library.BorrowItem(2, user);
        var borrowedItem3 = library.BorrowItem(3, user);
        if (borrowedItem3 == null)
        {
            Console.WriteLine("barmi");
        }
        else
        {
            Console.WriteLine("mas");
        }
        /*
        Assert.Multiple(() =>
        {
            Assert.That(borrowedItem1, Is.Not.Null);
            Assert.That(borrowedItem2, Is.Not.Null);
            Assert.That(true, Is.EqualTo(null == borrowedItem3));
        });*/
        Assert.That(borrowedItem3, Is.Null);
       
    }

    [Test]
    public void ReturnItem_ShouldSetReturnDate_Test()
    {
        var library = new Library(new List<Borrow>(), new List<Item>());
        var user = new Resident("John", 1);
        var item = new Item(1, "Sample Item");
        library.Items.Add(item);
        var borrowedItem = new Borrow(DateTime.Now, user, item);
        library.BorrowedItems.Add(borrowedItem);
        
        library.ReturnItem(item, user);
        
        Assert.IsNotNull(borrowedItem.ReturnDate);
    }
}