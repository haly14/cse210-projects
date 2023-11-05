using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
    }    
    public static void DisplayMenu()
    {
        Console.WriteLine($"\nYou have  points.");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("\nSelect one of the following goal types:");
            Console.WriteLine("    1. Simple Goal");
            Console.WriteLine("    2. Eternal Goal");
            Console.WriteLine("    3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
           
            // code for Simple, Eternal, or Checklist goals (inheritance class):
            Console.Write("\nWhat is the name of your goal? ");
            Console.Write("What is a short description of it? ");
            Console.Write("What is the amount of points associated with this goal? ");
            Console.Write("How many times does this goal need to be accomplished for a bonus? "); //only for Checklist goal 
            Console.Write("What is the bonus for accomplishing it that many times? "); //only for Checklist goal 
        }

        else if (choice == 2)
        {
            Console.WriteLine("\nThe goals are:");
            //list goals stored in list after selecting Option 1 from original menu.
            //when list checklist goal, include: "-- Currently completed: 0/3"
        }

        else if (choice == 3)
        {
            Console.WriteLine("\nWhat is the filename for the goal file? "); //choose any name. they chose goals.txt
        }

        else if (choice == 4)
        {
            Console.WriteLine("\nWhat is the filename for the goal file? "); // use same filename that you last saved them too. nothing will appear when you select List if you have saved then closed the file, until you load the saved file of goals.
        }

        else if (choice == 5)
        {
            Console.WriteLine("\nWhich goal did you accomplish? "); //helps to list goals first to remidn you which number is which.
            Console.WriteLine($"\nCongratulations! You have earned  points."); // after this, X appears in box to mark goal as done when list, currently completed number updated x/3. Points added to total with each 5. record event.
        }

        else if (choice == 6)
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