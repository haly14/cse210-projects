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
    public int Points { get; protected set; }
    public bool Completed { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        Points = 0;
        Completed = false;
    }

    public virtual void MarkComplete()
    {
        Completed = true;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{Name} - Points: {Points} - Completed: {(Completed ? "Yes" : "No")}");
    }
}