using System;
using System.Runtime.CompilerServices;
public class RunApplication
{
    private readonly List<Application> games;

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
        Console.WriteLine("\nThe Main Menu will have the following 3 options:");
        Console.WriteLine("    1. Major Body Systems Overview");
        Console.WriteLine("    2. Play New Game");
        Console.WriteLine("    3. Quit");
        Console.WriteLine("Select Option 1 to review a short description of each major body system.");
        Console.WriteLine("Select Option 2 to play a review game (Multiple Choice, Matching, or Short Answer Quiz).");
        Console.WriteLine("Select Option 3 to quit the application.");
        Console.WriteLine("\nFor each game option, you will select a question topic by entering a number 1-8 (corresponding to the 8 body systems).");
        Console.WriteLine("\nPress enter when you are finished reading the instructions to pull up the Main Menu.");
        Console.ReadLine(); 
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nAnatomy Learning Application! Main Menu: ");
        Console.WriteLine("    1. Major Body Systems Overview");
        Console.WriteLine("    2. Play New Game");
        Console.WriteLine("    3. Quit");
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n1. The Integumentary System");
                    Console.WriteLine("    Purpose: Protection against pathogens.");
                    Console.WriteLine("    Parts: Skin, hair, nails, glands, nerve endings.");
                    Console.WriteLine("2. The Skeletal System");
                    Console.WriteLine("    Purpose: Structural support, protection, movement.");
                    Console.WriteLine("    Parts: Bones, connective tissues.");
                    Console.WriteLine("3. The Muscular System");
                    Console.WriteLine("    Purpose: Movement.");
                    Console.WriteLine("    Parts: Muscles, connective tissues.");
                    Console.WriteLine("4. The Nervous System");
                    Console.WriteLine("    Purpose: Sensory and motor body contol.");
                    Console.WriteLine("    Parts: Brain, spinal cord, neurons.");
                    Console.WriteLine("5. The Circulatory System");
                    Console.WriteLine("    Purpose: Circulate blood components to lungs and body cells.");
                    Console.WriteLine("    Parts: Heart, blood vessels, blood.");
                    Console.WriteLine("6. The Respiratory System");
                    Console.WriteLine("    Purpose: Gas exchange in blood: carbon dioxide for oxygen.");
                    Console.WriteLine("    Parts: Lungs, trachea, upper respiratory tract.");
                    Console.WriteLine("7. The Digestive System");
                    Console.WriteLine("    Purpose: To break down food. Absorb nutrients and building blocks.");
                    Console.WriteLine("    Parts: Mouth, esophagus, stomach, small intestine, large intestine, accessory organs.");
                    Console.WriteLine("8. The Immune System");
                    Console.WriteLine("    Purpose: Identify, mount a defense against, and attack to destroy pathogens.");
                    Console.WriteLine("    Parts: Lymphocytes and leukocytes.");
                    Console.WriteLine("\nAre you finished reviewing? Press Enter to return to the main menu.");
                    Console.ReadLine(); 
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
        Console.WriteLine("    3. Return to Main Menu");
        Console.Write("Which game do you want to play? ");

        if (int.TryParse(Console.ReadLine(), out int gameTypeChoice))
        {

            int questionNumber;

            switch (gameTypeChoice)
            {
                case 1:
                    Console.Write("Enter the question number (1 to 8): ");
                    if (int.TryParse(Console.ReadLine(), out questionNumber) && questionNumber >= 1 && questionNumber <= 8)
                    {
                        var newMultChoice = new MultChoice("", 0);
                        newMultChoice.GenerateRandomQuestion(questionNumber);
                        games.Add(newMultChoice);
                    }
                    else
                    {
                        Console.WriteLine("Invalid question number.");
                    }
                    break;
                case 2:
                    Console.Write("Enter the question number (1 to 8): ");
                    if (int.TryParse(Console.ReadLine(), out questionNumber) && questionNumber >= 1 && questionNumber <= 8)
                    {
                        var newMatching = new Matching("", 0);
                        newMatching.GenerateRandomQuestion(questionNumber);
                        games.Add(newMatching);
                    }
                    else
                    {
                        Console.WriteLine("Invalid question number.");
                    }
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("Points updated.");
            UpdateTotalPoints();

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for game type.");
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
