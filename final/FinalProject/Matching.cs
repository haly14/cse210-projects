using System;
public class Matching : Application
{
    public Matching(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }
}