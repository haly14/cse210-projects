public class ListingActivity : Mindfulness
{
    public ListingActivity(string name, string description, int duration) : base (name, description, duration)
    {
        StartActivity();
    }

    public void StartListing(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(2);

        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            Console.WriteLine("");

        }

        EndActivity();
    }
}