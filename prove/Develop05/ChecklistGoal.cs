using System;
public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        OriginalPoints = points;
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