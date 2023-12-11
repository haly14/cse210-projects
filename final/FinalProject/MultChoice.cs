using System;
public class MultChoice : Application
{
    public MultChoice(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }
}