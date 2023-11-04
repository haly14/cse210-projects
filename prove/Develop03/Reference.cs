public class Reference
{
    public string FullReference { get; private set; }
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }

    public Reference(string fullReference)
    {
        FullReference = fullReference;
        ParseReference(fullReference);
    }

    private void ParseReference(string fullReference)
    {
        // Implement parsing logic to extract book, chapter, and verse information
        // You'll need to handle single verses and verse ranges like "Proverbs 3:5-6"
    }
}