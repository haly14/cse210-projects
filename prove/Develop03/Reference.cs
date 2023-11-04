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
        // Split the full reference by space and colon
        string[] parts = fullReference.Split(' ', ':');

        // Check if we have enough parts to proceed
        if (parts.Length >= 2)
        {
            // The book name is in the first part
            Book = parts[0];

            // Parse the chapter and start verse
            if (int.TryParse(parts[1], out int chapter))
            {
                Chapter = chapter;

                // Check if we have a verse range
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

