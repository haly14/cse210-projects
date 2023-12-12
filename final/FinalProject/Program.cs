using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        RunApplication runApplication = new RunApplication();
        runApplication.Run();
        
    }
}

public abstract class Application
{
    public string Answer { get; protected set; }
    public int Points { get; protected set; }
    public int OriginalPoints { get; protected set; }
    public bool Completed { get; protected set; }

    public Application(string answer, int points)
    {
        Answer = answer;
        Points = 0;
        OriginalPoints = points;
        Completed = false;
    }

    public virtual void MarkComplete(bool correctAnswer)
    {
        Completed = true;
        Points += correctAnswer ? OriginalPoints : 0;
    }
    
}