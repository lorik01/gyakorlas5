namespace gyakorlas5;

public class Resident : User
{
    public Resident(string name, uint id) : base(name, id)
    {
    }

    public override int BorrowCapacity()
    {
        return 2;
    }
}