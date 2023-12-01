using System;
public class GoalProgram
{
    private List<Goal> goals;
    private SaveLoadGoals saveLoadGoals = new SaveLoadGoals();

    public GoalProgram()
    {
        goals = new List<Goal>();
        // You may want to load goals from a file here using SaveLoadGoals
        LoadGoals();
    }

    public void Run()
    {
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        Console.WriteLine($"\nYou have {CalculateTotalPoints()} points.");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
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

    private void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out int goalTypeChoice))
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out int goalPoints))
            {
                Goal newGoal;

                switch (goalTypeChoice)
                {
                    case 1:
                        newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                        break;
                    case 2:
                        newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                        break;
                    case 3:
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            Console.Write("What is the bonus for accomplishing the goal that many times? ");
                            if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                            {
                                newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints);
                                break;
                            }
                        }
                        Console.WriteLine("Invalid input. Please enter valid integers for target count and bonus points.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                goals.Add(newGoal);

                Console.WriteLine("Goal created successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for goal points.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for goal type.");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. [ ] {goals[i].Name} ({goals[i].Description})");

            if (goals[i] is ChecklistGoal checklistGoal)
            {
                Console.Write($" -- Currently completed: {checklistGoal.CompletedCount}/{checklistGoal.TargetCount}");
            }

            Console.WriteLine();
        }
    }

    private void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        SaveLoadGoals saveLoadGoals = new SaveLoadGoals();
        saveLoadGoals.SaveGoals(filename, CalculateTotalPoints(), goals);
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        List<Goal> loadedGoals = saveLoadGoals.LoadGoals(filename);  // Adjust according to your SaveLoadGoals class
        goals.Clear();  // Clear existing goals
        goals.AddRange(loadedGoals);  // Add loaded goals
        Console.WriteLine("Goals loaded successfully.");
    }

    private void RecordEvent(string goalName = null)
    {
        if (goalName == null)
        {
            Console.WriteLine("\nWhich goal did you accomplish? ");
            goalName = Console.ReadLine();
        }

        var goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.MarkComplete();
            Console.WriteLine($"Event recorded! {goal.OriginalPoints} points.");
            UpdateTotalPoints();
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    private void UpdateTotalPoints()
    {
        int totalPoints = CalculateTotalPoints();
        Console.WriteLine($"You have {totalPoints} points.");
    }

    private int CalculateTotalPoints()
    {
        return goals.Sum(g => g.Points);
    }
}
