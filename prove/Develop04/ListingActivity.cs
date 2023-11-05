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

        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            Console.WriteLine("List as many responses as you can to the following prompt: ");
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"---{randomPrompt}---");
            Console.WriteLine("You may begin in ");
            DisplayCountdown(5);
            secondsElapsed += 5;
            
        }

        EndActivity();
    }
}