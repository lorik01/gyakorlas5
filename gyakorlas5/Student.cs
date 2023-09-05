namespace gyakorlas5;

public class Student : User
{
    public Student(string name, uint id) : base(name, id)
    {
    }
    
    public override int BorrowCapacity()
    {
        return 5;
    }
}