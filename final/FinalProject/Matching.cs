using System;
public class Matching : Application
{
    public Matching(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        string userAnswer;

        switch (questionNumber)
        {
            case 1:
                Console.Write("Matching Question 1: ");
                userAnswer = Console.ReadLine();
                break;
            case 2:
                Console.Write("Matching Question 2: ");
                userAnswer = Console.ReadLine();
                break;
            case 3:
                Console.Write("Matching Question 3: ");
                userAnswer = Console.ReadLine();
                break;
            case 4:
                Console.Write("Matching Question 4: ");
                userAnswer = Console.ReadLine();
                break;
            case 5:
                Console.Write("Matching Question 5: ");
                userAnswer = Console.ReadLine();
                break;
            case 6:
                Console.Write("Matching Question 6: ");
                userAnswer = Console.ReadLine();
                break;
            case 7:
                Console.Write("Matching Question 7: ");
                userAnswer = Console.ReadLine();
                break;
            case 8:
                Console.Write("Matching Question 8: ");
                userAnswer = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid question number.");
                break;
        }
    }
    public void SetPoints(int points)
    {
        Points = points;
    }
}