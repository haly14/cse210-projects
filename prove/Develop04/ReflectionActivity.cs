public class ReflectionActivity : Mindfulness
{
    public ReflectionActivity(string name, string description, int duration) : base (name, description, duration)
    {
        StartActivity();
    }

    public void StartReflection(int duration)
    {
        Console.Clear();
        Console.WriteLine("Great ready...");
        DisplaySpinner(2); // Display spinner for 2 seconds

        EndActivity();
    }
}