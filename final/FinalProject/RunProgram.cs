using System;
public class RunApplication
{
    private List<Application> games;
    private SaveLoadGames saveLoadGames = new SaveLoadGames();

    public RunApplication()
    {
        games = new List<Application>();
        LoadGames();
    }

    public void Run()
    {
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        Console.WriteLine($"\nYou have {CalculateTotalPoints()} points.");
        Console.WriteLine("\nApplication Options:");
        Console.WriteLine("    1. Play New Game");
        Console.WriteLine("    2. List Quiz Answers");
        Console.WriteLine("    3. Save Quiz Answers");
        Console.WriteLine("    4. Load Quiz Answers");
        Console.WriteLine("    5. Record Answer");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    PlayNewGame();
                    break;
                case 2:
                    ListGames();
                    break;
                case 3:
                    SaveGames();
                    break;
                case 4:
                    LoadGames();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        DisplayMenu();
    }

    private void PlayNewGame()
    {
        Console.WriteLine("\nThe game options are:");
        Console.WriteLine("    1. Multiple Choice");
        Console.WriteLine("    2. Matching");
        Console.WriteLine("    3. Short Answer Quiz");
        Console.Write("Which game do you want to play? ");

        if (int.TryParse(Console.ReadLine(), out int gameTypeChoice))
        {
            Console.Write("Question 1: ");
            string userAnswer = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out int gamePoints))
            {
                Application newGame;

                switch (gameTypeChoice)
                {
                    case 1:
                        newGame = new MultChoice(userAnswer, gamePoints);
                        break;
                    case 2:
                        newGame = new Matching(userAnswer, gamePoints);
                        break;
                    case 3:
                        newGame = new ShortAnswerQuiz(userAnswer, gamePoints);
                        Console.WriteLine("Invalid input. Please enter valid integers for target count and bonus points.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                games.Add(newGame);

                Console.WriteLine("Game completed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for goal points.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for game type.");
        }
    }

    private void ListGames()
    {
        Console.WriteLine("\nThe games are:");

        for (int i = 0; i < games.Count; i++)
        {
            Console.Write($"{i + 1}. [ ] {games[i].Answer}");

            if (games[i] is ShortAnswerQuiz shortAnswerQuiz)
            {
                Console.Write($" -- ");
            }

            Console.WriteLine();
        }
    }

    private void SaveGames()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        SaveLoadGames saveLoadGames = new SaveLoadGames();
        saveLoadGames.SaveGames(filename, CalculateTotalPoints(), ListGames);
        Console.WriteLine("Games saved successfully.");
    }

    private void LoadGames()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        List<Application> loadedGames = saveLoadGames.LoadGames(filename);
        games.Clear();
        games.AddRange(loadedGames);
        Console.WriteLine("Games loaded successfully.");
    }

    private void RecordEvent(string userAnswer = null)
    {
        if (userAnswer == null)
        {
            Console.WriteLine("\nWhich game did you play? ");
            userAnswer = Console.ReadLine();
        }

        var game = games.Find(g => g.Answer == userAnswer);
        if (game != null)
        {
            bool correctAnswer;
            
            if (game is MultChoice || game is Matching)
            {
                Console.Write($"Is the answer correct? (yes/no): ");
                correctAnswer = Console.ReadLine()?.Trim().ToLower() == "yes";
            }
            else if (game is ShortAnswerQuiz)
            {
                correctAnswer = true;
            }
            else
            {
                Console.WriteLine("Unsupported game type.");
                return;
            }

            game.MarkComplete(correctAnswer);
            Console.WriteLine($"Game recorded! {correctAnswer} - {game.OriginalPoints} points.");
            UpdateTotalPoints();
        }
        else
        {
            Console.WriteLine("Game not found!");
        }
    }

    private void UpdateTotalPoints()
    {
        int totalPoints = CalculateTotalPoints();
        Console.WriteLine($"You have {totalPoints} points.");
    }

    private int CalculateTotalPoints()
    {
        return games.Sum(g => g.Points);
    }
}
