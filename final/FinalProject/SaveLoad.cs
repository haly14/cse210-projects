using System;
using System.Collections.Generic;
using System.IO;

public class SaveLoadGames
{
    public void SaveGames(string fileName, List<ShortAnswerQuiz> shortAnswerQuizzes)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (ShortAnswerQuiz shortAnswerQuiz in shortAnswerQuizzes)
                {
                    string gameLine = $"{shortAnswerQuiz.GetType().Name}:{shortAnswerQuiz.Answer},{shortAnswerQuiz.CompletedCount}";
                    writer.WriteLine(gameLine);
                }
            }
            Console.WriteLine($"Games saved to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving games: {ex.Message}");
        }
    }

    public List<ShortAnswerQuiz> LoadShortAnswerQuizzes(string fileName)
    {
        List<ShortAnswerQuiz> loadedShortAnswerQuizzes = new List<ShortAnswerQuiz>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string gameLine = reader.ReadLine();
                    ShortAnswerQuiz shortAnswerQuiz = CreateShortAnswerQuizFromLine(gameLine);
                    if (shortAnswerQuiz != null)
                    {
                        loadedShortAnswerQuizzes.Add(shortAnswerQuiz);
                    }
                }
            }

            Console.WriteLine($"Short Answer Quizzes loaded from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading Short Answer Quizzes: {ex.Message}");
        }

        return loadedShortAnswerQuizzes;
    }

    private ShortAnswerQuiz CreateShortAnswerQuizFromLine(string gameLine)
    {
        try
        {
            string[] parts = gameLine.Split(':');

            if (parts.Length >= 2)
            {
                string gameType = parts[0];
                string gameDetails = parts[1];

                switch (gameType)
                {
                    case "ShortAnswerQuiz":
                        string[] quizParts = gameDetails.Split(',');
                        if (quizParts.Length == 2 && int.TryParse(quizParts[1], out int quizPoints))
                        {
                            ShortAnswerQuiz shortAnswerQuiz = new ShortAnswerQuiz(quizParts[0], quizPoints);
                            shortAnswerQuiz.CompletedCount = int.Parse(quizParts[1]);
                            return shortAnswerQuiz;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid format for ShortAnswerQuiz: {gameLine}");
                        }
                        break;
                    default:
                        Console.WriteLine($"Unknown game type: {gameType}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Invalid format for gameLine: {gameLine}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format error in gameLine: {gameLine}. Details: {ex.Message}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Index out of range in gameLine: {gameLine}. Details: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating ShortAnswerQuiz from line: {ex.Message}");
        }

        return null;
    }

    internal void SaveGames(string filename, int v, Action listGames)
    {
        throw new NotImplementedException();
    }
}
