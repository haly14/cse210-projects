public class ListingActivity : Mindfulness
{
    public ListingActivity(string name, string description, int duration) : base (name, description, duration)
    {
        StartActivity();
    }

    public void StartListing(int duration)
    {
        Console.Clear();
        Console.WriteLine("Great ready...");
        DisplaySpinner(2); // Display spinner for 2 seconds

        EndActivity();
    }
}