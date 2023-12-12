using System;
public class MultChoice : Application
{
    public MultChoice(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        string userAnswer;

        switch (questionNumber)
        {
            case 1:
                Console.Write("Multiple Choice Question 1: ");
                userAnswer = Console.ReadLine();
                break;
            case 2:
                Console.Write("Multiple Choice Question 2: ");
                userAnswer = Console.ReadLine();
                break;
            case 3:
                Console.Write("Multiple Choice Question 3: ");
                userAnswer = Console.ReadLine();
                break;
            case 4:
                Console.Write("Multiple Choice Question 4: ");
                userAnswer = Console.ReadLine();
                break;
            case 5:
                Console.Write("Multiple Choice Question 5: ");
                userAnswer = Console.ReadLine();
                break;
            case 6:
                Console.Write("Multiple Choice Question 6: ");
                userAnswer = Console.ReadLine();
                break;
            case 7:
                Console.Write("Multiple Choice Question 7: ");
                userAnswer = Console.ReadLine();
                break;
            case 8:
                Console.Write("Multiple Choice Question 8: ");
                userAnswer = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid question number.");
                userAnswer = Console.ReadLine();
                break;
        }
    }
    public void SetPoints(int points)
    {
        Points = points;
    }
}
