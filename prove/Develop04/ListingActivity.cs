public class ListingActivity : Mindfulness
{
    private string[] _prompts;
    public ListingActivity(string name, string description, int duration) : base (name, description, duration)
    {
        _prompts = new string[]
        {
            "When have you felt the Holy Ghost this month?",
            "When have you experienced joy this week?",
            "What have you felt excited about in the past month?",
            "What beautiful things have you seen this week?",
            "What compliments have you been given this month?",
            "When have you experienced peace this week?"
        };
        
        StartActivity();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }

    public void StartListing(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(2);

        List<string> listedItems = new List<string>();

        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            Console.WriteLine("\nList as many responses as you can to the following prompt: ");
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"\n---{randomPrompt}---");
            Console.WriteLine("\nYou may begin in ");
            DisplayCountdown(5);
            secondsElapsed += 5;

            DateTime startTime = DateTime.Now;
            while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                listedItems.Add(item);
            }

            break;
        }

        int numberOfItemsListed = listedItems.Count;
        Console.WriteLine($"Great work. You listed {numberOfItemsListed} items.");
        DisplaySpinner(5);

        EndActivity();
    }
}