using System;
using System.Collections.Generic;

public class Scripture
{
    private string _text;
    private List<string> _words;

    public Reference Reference { get; private set; }
    public string Text
    {
        get { return _text; }
        private set { _text = value; }
    }

    public Scripture(string fullReference, string text)
    {
        Reference = new Reference(fullReference);
        Text = text;
        _words = new List<string>(text.Split(' '));
    }

    public void HideWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = GetRandomHiddenWordIndex();
            if (index >= 0)
            {
                _words[index] = new string('_', _words[index].Length);
            }
        }

        Text = string.Join(" ", _words);
    }

    private int GetRandomHiddenWordIndex()
    {
        var hiddenWordsIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].Contains("_"))
            {
                hiddenWordsIndices.Add(i);
            }
        }

        if (hiddenWordsIndices.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(hiddenWordsIndices.Count);
            return hiddenWordsIndices[randomIndex];
        }

        return -1;
    }

    public override string ToString()
    {
        return $"{Reference.FullReference} - {Text}";
    }
}
