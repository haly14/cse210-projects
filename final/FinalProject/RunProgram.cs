using System;
using System.Runtime.CompilerServices;
public class RunApplication
{
    private List<Application> games;
    private SaveLoadGames saveLoadGames = new SaveLoadGames();

    public RunApplication()
    {
        games = new List<Application>();
    }

    public void Run()
    {
        Console.WriteLine("\nWelcome to the Anatomy Learning Application!");
        Console.WriteLine("\nThis application will help you review the 8 major body systems studied in Anatomy: ");
        Console.WriteLine("    1. The Integumentary System");
        Console.WriteLine("    2. The Skeletal System");
        Console.WriteLine("    3. The Muscular System");
        Console.WriteLine("    4. The Nervous System");
        Console.WriteLine("    5. The Circulatory System");
        Console.WriteLine("    6. The Respiratory System");
        Console.WriteLine("    7. The Digestive System");
        Console.WriteLine("    8. The Immune System");
        Console.WriteLine("\nPlease remember the number associated with the body system that you want to study.");
        Console.WriteLine("You will use the number to select the associated question later on.");
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        Console.WriteLine($"\nYou currently have {CalculateTotalPoints()} points.");
        Console.WriteLine("\nPlease select an option from the menu below: ");
        Console.WriteLine("    1. Major Body Systems Overview");
        Console.WriteLine("    2. Play New Game");
        Console.WriteLine("    3. Quit");
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. The Integumentary System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("2. The Skeletal System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("3. The Muscular System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("4. The Nervous System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("5. The Circulatory System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("6. The Respiratory System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("7. The Digestive System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    Console.WriteLine("8. The Immune System");
                    Console.WriteLine("    Purpose: .");
                    Console.WriteLine("    Parts: .");
                    break;
                case 2:
                    PlayNewGame();
                    break;
                case 3:
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

            int gamePoints;
            string userAnswer;

            switch (gameTypeChoice)
            {
                case 1:
                    Console.Write("Multiple Choice Question 1: ");
                    userAnswer = Console.ReadLine();
                    gamePoints = 5;
                    var newMultChoice = new MultChoice(userAnswer, gamePoints);
                    games.Add(newMultChoice);
                    break;
                case 2:
                    Console.Write("Matching Question 1: ");
                    userAnswer = Console.ReadLine();
                    gamePoints = 5;
                    var newMatching = new Matching(userAnswer, gamePoints);
                    games.Add(newMatching);
                    break;
                case 3:
                    Console.WriteLine("\nPlease select an option from the menu below: ");
                    Console.WriteLine("    1. Complete New Short Answer Question");
                    Console.WriteLine("    2. List Quiz Answers");
                    Console.WriteLine("    3. Save Quiz Answers");
                    Console.WriteLine("    4. Load Quiz Answers");
                    Console.WriteLine("    5. Quit");
                    Console.Write("Select a choice from the menu: ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.Write("Short Answer Question 1: ");
                                userAnswer = Console.ReadLine();
                                gamePoints = 10;
                                var newShortAnswerQuiz = new ShortAnswerQuiz(userAnswer, gamePoints);
                                games.Add(newShortAnswerQuiz);
                                break;
                            case 2:
                                ListShortAnswerQuizzes();
                                break;
                            case 3:
                                SaveShortAnswerQuizzes();
                                break;
                            case 4:
                                LoadShortAnswerQuizzes();
                                break;
                            case 5:
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
                    
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("Game recorded! Points updated.");
            UpdateTotalPoints();

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for game type.");
        }
    }

    private void ListShortAnswerQuizzes()
    {
        Console.WriteLine("\nPreviously saved short answer responses:");

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

    private void SaveShortAnswerQuizzes()
    {
        Console.Write("\nWhat is the filename for the Short Answer Quiz file? ");
        string filename = Console.ReadLine();
        List<ShortAnswerQuiz> shortAnswerQuizzes = games.OfType<ShortAnswerQuiz>().ToList();
        saveLoadGames.SaveGames(filename, shortAnswerQuizzes);
        Console.WriteLine("Short Answer Quizzes saved successfully.");
    }

    private void LoadShortAnswerQuizzes()
    {
        Console.Write("\nWhat is the filename for the Short Answer Quiz file? ");
        string filename = Console.ReadLine();
        List<ShortAnswerQuiz> loadedShortAnswerQuizzes = saveLoadGames.LoadShortAnswerQuizzes(filename);
        games.RemoveAll(g => g is ShortAnswerQuiz);
        games.AddRange(loadedShortAnswerQuizzes);
        Console.WriteLine("Short Answer Quizzes loaded successfully.");
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
