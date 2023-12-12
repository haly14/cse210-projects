using System;
public class MultChoice : Application
{
    public MultChoice(string answer, int points) : base(answer, points)
    {
        Console.Write("Multiple Choice Question 2: ");
        OriginalPoints = points;
    }
}