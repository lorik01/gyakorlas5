namespace gyakorlas5;

public abstract class User
{
    public string Name { get; set; }
    public uint Id { get; set; }
    
    public User(string name, uint id)
    {
        Name = name;
        Id = id;
    }

    public abstract int BorrowCapacity();
}