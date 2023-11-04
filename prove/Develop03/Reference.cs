using System;

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
        string[] parts = fullReference.Split(' ', ':');

        if (parts.Length >= 2)
        {
            Book = parts[0];

            if (int.TryParse(parts[1], out int chapter))
            {
                Chapter = chapter;

                if (parts.Length >= 4 && parts[2] == "-" && int.TryParse(parts[3], out int endVerse))
                {
                    StartVerse = Chapter;
                    EndVerse = endVerse;
                }
                else if (int.TryParse(parts[2], out int verse))
                {
                    StartVerse = verse;
                    EndVerse = verse;
                }
            }
        }
    }
}

