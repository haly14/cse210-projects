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
            Points += BonusPoints;
        }
        else
        {
            Points += OriginalPoints;
        }
    }

    public override void DisplayGoal()
    {
        string completionStatus = Completed ? "[x]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name} ({Description}) - Completed {CompletedCount}/{TargetCount} times");
    }
}