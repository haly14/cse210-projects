using System;
using System.Threading;

public class Mindfulness
{
    private string _name {get; set;}
    private string _description {get; set;}
    private int _duration {get; set;}

    public Mindfulness(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name}\n{_description}\n");
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        DisplaySpinner(3); // Display spinner for 3 seconds
        Console.WriteLine($"\nYou have completed another {_name}.");
        DisplaySpinner(3); 
        Console.Clear();
        Program.DisplayMenu();
    }

    public void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Clear displayed digit
        }
    }

    public void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b \b \b"); // Clear display spinner
        }
    }

}