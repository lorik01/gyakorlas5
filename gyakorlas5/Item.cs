namespace gyakorlas5;

public class Item
{
    public uint Id { get; init; }
    public string Name { get; init; }

    public Item(uint id, string name)
    {
        Id = id;
        Name = name;
    }
}