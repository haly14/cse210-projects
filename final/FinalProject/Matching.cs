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
                Console.Write("\nMatching Question 1 (Integumentary System): ");
                userAnswer = Console.ReadLine();
                break;
            case 2:
                Console.Write("\nMatching Question 2 (Skeletal System): ");
                userAnswer = Console.ReadLine();
                break;
            case 3:
                Console.Write("\nMatching Question 3 (Muscular System): ");
                userAnswer = Console.ReadLine();
                break;
            case 4:
                Console.Write("\nMatching Question 4 (Nervous System): ");
                userAnswer = Console.ReadLine();
                break;
            case 5:
                Console.Write("\nMatching Question 5 (Circulatory System): ");
                userAnswer = Console.ReadLine();
                break;
            case 6:
                Console.Write("\nMatching Question 6 (Respiratory System): ");
                userAnswer = Console.ReadLine();
                break;
            case 7:
                Console.Write("\nMatching Question 7 (Digestive System): ");
                userAnswer = Console.ReadLine();
                break;
            case 8:
                Console.Write("\nMatching Question 8 (Immune System): ");
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