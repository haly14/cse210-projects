using System;
using System.Collections.Generic;
using System.IO;

public class SaveLoadGoals
{
    public void SaveGoals(string fileName, int userPoints, List<Goal> goalsList)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(userPoints);
                foreach (Goal goal in goalsList)
                {
                    string goalLine;
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        goalLine = $"{goal.GetType().Name}:{goal.Name},{checklistGoal.TargetCount},{checklistGoal.CompletedCount},{checklistGoal.Description}";
                    }
                    else
                    {
                        goalLine = $"{goal.GetType().Name}:{goal.Name}";
                    }
                    writer.WriteLine(goalLine);
                }
            }
            Console.WriteLine($"Goals saved to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public List<Goal> LoadGoals(string fileName)
    {
        List<Goal> loadedGoals = new List<Goal>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Read user points
                int userPoints = int.Parse(reader.ReadLine());

                // Read and create goals
                while (!reader.EndOfStream)
                {
                    string goalLine = reader.ReadLine();
                    Goal goal = CreateGoalFromLine(goalLine);
                    if (goal != null)
                    {
                        loadedGoals.Add(goal);
                    }
                }
            }

            Console.WriteLine($"Goals loaded from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

        return loadedGoals;
    }

    private Goal CreateGoalFromLine(string goalLine)
    {
        try
        {
            string[] parts = goalLine.Split(':');

            if (parts.Length >= 2)
            {
                string goalType = parts[0];
                string goalDetails = parts[1];

                switch (goalType)
                {
                    case "SimpleGoal":
                        return new SimpleGoal(goalDetails);
                    case "EternalGoal":
                        return new EternalGoal(name, description, points);
                    case "ChecklistGoal":
                        // Parse additional information for ChecklistGoal and create an instance
                        string[] checklistParts = goalDetails.Split(',');
                        if (checklistParts.Length == 5 && int.TryParse(checklistParts[2], out int points) && int.TryParse(checklistParts[3], out int targetCount) && int.TryParse(checklistParts[4], out int completedCount))
                        {
                            return new ChecklistGoal(checklistParts[0], checklistParts[1], points, targetCount, completedCount);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid format for ChecklistGoal: {goalLine}");
                        }
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Invalid format for goalLine: {goalLine}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating goal from line: {ex.Message}");
        }

        return null;
    }
}
