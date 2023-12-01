using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        OriginalPoints = points;
    }

    public override void MarkComplete()
    {
        base.MarkComplete();
        Points += OriginalPoints;
    }
}