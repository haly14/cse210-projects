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

        int choice = int.Parse(Console.ReadLine());

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

        DisplayMenu();
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        Console.Write("What is the name of your goal? ");
        Console.Write("What is a short description of it? ");
        Console.Write("What is the amount of points associated with this goal? ");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
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

    private void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish? ");
        string goalName = Console.ReadLine();
        RecordEvent(goalName);
    }

    private void RecordEvent(string goalName)
    {
        var goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.MarkComplete();
            Console.WriteLine("Event recorded!");
            Console.WriteLine($"Congratulations! You have earned {goal.Points} points.");
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    private int CalculateTotalPoints()
    {
        return goals.Sum(g => g.Points);
    }
}
