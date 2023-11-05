using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
    }    
    public static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Clear();

            string activityName = "Breathing Activity";
            string activityDescription = "This activity will help you relax by walking you through a slow breathing exercise. Clear your mind and focus on your breathing.";
            int activityDuration = EnterDuration();
            BreathingActivity breathingActivity = new BreathingActivity(activityName, activityDescription, activityDuration);
            breathingActivity.StartBreathing(activityDuration);
        }

        else if (choice == 2)
        {
            Console.Clear();
            string activityName = "Reflection Activity";
            string activityDescription = "This activity will help you reflect on times in your life when you hae shown strength and resilience. This will help you to recognize the power you have and how you can apply it to other aspects of your life.";
            int activityDuration = EnterDuration();
            ReflectionActivity reflectionActivity = new ReflectionActivity(activityName, activityDescription, activityDuration);
            reflectionActivity.StartReflection(activityDuration);
        }

        else if (choice == 3)
        {
            Console.Clear();
            string activityName = "Listing Activity";
            string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain category.";
            int activityDuration = EnterDuration();
            ListingActivity listingActivity = new ListingActivity(activityName, activityDescription, activityDuration);
            listingActivity.StartListing(activityDuration);
        }
       
        else if (choice == 4)
        {
            return;
        }

        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private static int EnterDuration()
    {
        Console.Write("How long, in seconds, would you like your session to be? ");
        return int.Parse(Console.ReadLine());
    }
}