public class ReflectionActivity : Mindfulness
{
    private string[] _prompts;
    public ReflectionActivity(string name, string description, int duration) : base (name, description, duration)
    {
        _prompts = new string[]
        {
            "Think of a time when you did something really difficult.",
            "Think of a time when someone told you that you had been resilient.",
            "Think of an experience when you feel that you showed resilience.",
            "Think of a time when someone told you that you showed strength.",
            "Think of an experience when you feel that you showed strength."
        };

        StartActivity();
    }

    public void StartReflection(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(2);

        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"---{_prompts}---");
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine(); // Wait for user to press Enter

            Console.WriteLine("How did you feel when the experience ended?");
            DisplaySpinner(10);
            Console.WriteLine("What was your favorite thing about this experience?");
            DisplaySpinner(10);
        }

        EndActivity();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}