using System;

class Program
{
    static void Main(string[] args)
    {
        GoalProgram goalProgram = new GoalProgram();
        goalProgram.Run();
    }
}

public abstract class Goal
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }
    public int OriginalPoints { get; protected set; }
    public bool Completed { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = 0;
        OriginalPoints = points;
        Completed = false;
    }

    public virtual void MarkComplete()
    {
        Completed = true;
        Points += OriginalPoints;
    }

    public virtual void DisplayGoal()
    {
        string completionStatus = Completed ? "[x]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name} ({Description})");
    }
}