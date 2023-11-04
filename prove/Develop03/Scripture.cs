public class Scripture
{
    private string _text;

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
    }

    public void HideWords(int count)
    {
        // Implement logic to hide 'count' number of words in the scripture text
    }

    public override string ToString()
    {
        // Implement ToString() to display the scripture with reference
        return $"{Reference.FullReference} - {Text}";
    }
}