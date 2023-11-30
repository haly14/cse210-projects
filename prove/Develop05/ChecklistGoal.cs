public class ChecklistGoal : Goal
{
    public string Description { get; set; }
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }

    public ChecklistGoal(string name, int targetCount, int completedCount) : base(name)
    {
        Description = ""; // or provide a default description
        TargetCount = targetCount;
        CompletedCount = 0;
    }


    public override void MarkComplete()
    {
        CompletedCount++;
        if (CompletedCount == TargetCount)
        {
            base.MarkComplete();
            Points += 500;
        }
        else
        {
            Points += 50;
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{Name} - Points: {Points} - Completed: {(Completed ? "Yes" : "No")} - Completed {CompletedCount}/{TargetCount} times");
    }
}