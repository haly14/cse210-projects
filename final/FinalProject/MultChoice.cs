using System;
public class MultChoice : Application
{
    public MultChoice(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        switch (questionNumber)
        {
            case 1:
                Console.Write("Multiple Choice Question 1: ");
                break;
            case 2:
                Console.Write("Multiple Choice Question 2: ");
                break;
            case 3:
                Console.Write("Multiple Choice Question 3: ");
                break;
            case 4:
                Console.Write("Multiple Choice Question 4: ");
                break;
            case 5:
                Console.Write("Multiple Choice Question 5: ");
                break;
            case 6:
                Console.Write("Multiple Choice Question 6: ");
                break;
            case 7:
                Console.Write("Multiple Choice Question 7: ");
                break;
            case 8:
                Console.Write("Multiple Choice Question 8: ");
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
