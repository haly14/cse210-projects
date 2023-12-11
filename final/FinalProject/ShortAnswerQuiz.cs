using System;
public class ShortAnswerQuiz : Application
{
    public int CompletedCount { get; set; }

    public ShortAnswerQuiz(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public override void MarkComplete(bool correctAnswer)
    {
        base.MarkComplete(correctAnswer);
        Points += correctAnswer ? Points : 0;
    }

    public override void DisplayPoints()
    {
        string completionStatus = Completed ? "[x]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Answer}");
    }
}