namespace gyakorlas5;

public class CD : Item
{
    public uint NumberOfTracks { get; init; }

    public CD(uint id, string name, uint numberOfTracks) : base(id, name)
    {
        NumberOfTracks = numberOfTracks;
    }
}