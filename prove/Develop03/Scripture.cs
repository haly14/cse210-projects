using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;

    public Reference Reference { get; private set; }

    public Scripture(string fullReference, string text)
    {
        Reference = new Reference(fullReference);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords(int count)
    {
        var wordsToHide = _words.Where(word => !word.IsHidden).ToList();
        var random = new Random();

        for (int i = 0; i < count; i++)
        {
            if (wordsToHide.Count > 0)
            {
                int index = random.Next(wordsToHide.Count);
                wordsToHide[index].Hide();
                wordsToHide.RemoveAt(index);
            }
        }
    }

    public override string ToString()
    {
        string displayedText = string.Join(" ", _words.Select(word => word.ToString()));
        return $"{Reference.FullReference} - {displayedText}";
    }
}
