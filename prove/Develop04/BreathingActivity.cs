public class BreathingActivity : Mindfulness
{
    public BreathingActivity(string name, string description, int duration) : base (name, description, duration)
    {
        StartActivity();
    }

    public void StartBreathing(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(2);

        int secondsElapsed = 0;
        while (secondsElapsed < duration)
        {
            Console.Write("\nBreathe in...");
            DisplayCountdown(8);
            secondsElapsed += 8;

            Console.Write("\nAnd breathe out...");
            DisplayCountdown(8);
            secondsElapsed += 8;
            Console.WriteLine();
        }

        EndActivity();
    }
}