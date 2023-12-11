using System;
using System.Collections.Generic;
using System.IO;

public class SaveLoadGames
{
    public void SaveGames(string fileName, int userPoints, List<Application> gamesList)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(userPoints);
                foreach (Application game in gamesList)
                {
                    string gameLine;
                    if (game is ShortAnswerQuiz shortAnswerQuiz)
                    {
                        gameLine = $"{game.GetType().Name}:{game.Answer},{shortAnswerQuiz.CompletedCount}";
                    }
                    else
                    {
                        gameLine = $"{game.GetType().Name}:{game.Answer}";
                    }
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

    public List<Application> LoadGames(string fileName)
    {
        List<Application> loadedGames = new List<Application>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                int userPoints = int.Parse(reader.ReadLine());

                while (!reader.EndOfStream)
                {
                    string gameLine = reader.ReadLine();
                    Application game = CreateGameFromLine(gameLine);
                    if (game != null)
                    {
                        loadedGames.Add(game);
                    }
                }
            }

            Console.WriteLine($"Games loaded from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading games: {ex.Message}");
        }

        return loadedGames;
    }

    private Application CreateGameFromLine(string gameLine)
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
                    case "MultChoice":
                        string[] simpleParts = gameDetails.Split(',');
                        if (simpleParts.Length == 3 && int.TryParse(simpleParts[1], out int simplePoints))
                        {
                            return new MultChoice(simpleParts[0], simplePoints);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid format for MultChoice: {gameLine}");
                        }
                        break;

                    case "Matching":
                        string[] eternalParts = gameDetails.Split(',');
                        if (eternalParts.Length == 3 && int.TryParse(eternalParts[1], out int eternalPoints))
                        {
                            return new Matching(eternalParts[0], eternalPoints);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid format for Matching: {gameLine}");
                        }
                        break;

                    case "ShortAnswerQuiz":
                        string[] quizParts = gameDetails.Split(',');
                        if (quizParts.Length == 2 && int.TryParse(quizParts[1], out int quizPoints))
                        {
                            return new ShortAnswerQuiz(quizParts[0], quizPoints);
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
            Console.WriteLine($"Error creating game from line: {ex.Message}");
        }

        return null;
    }

    internal void SaveGames(string filename, int v, Action listGames)
    {
        throw new NotImplementedException();
    }
}
