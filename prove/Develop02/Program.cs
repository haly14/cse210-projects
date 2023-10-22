using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}

class Journal
{
    static List<JournalEntry> entries = new List<JournalEntry>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your personal online journal.");
        string numberInput;

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            numberInput = Console.ReadLine();

            if (numberInput == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                string randomQuestion = GetRandomPrompt();

                Console.WriteLine("[" + dateText + "]");
                Console.WriteLine(randomQuestion);
                string dataEntry = Console.ReadLine();

                entries.Add(new JournalEntry(randomQuestion, dataEntry, dateText));
            }
            else if (numberInput == "2")
            {
                Console.WriteLine("Your journal:");
                foreach (var entry in entries)
                {
                    Console.WriteLine($"Date: {entry.Date}");
                    Console.WriteLine($"Prompt: {entry.Prompt}");
                    Console.WriteLine($"Response: {entry.Response}");
                    Console.WriteLine();
                }
            }
            else if (numberInput == "3")
            {
                LoadJournalFromFile();
            }
            else if (numberInput == "4")
            {
                SaveJournalToFile();
            }
            else if (numberInput == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, 3, 4, or 5.");
            }
        }
    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load: ");
        string loadFileName = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(loadFileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    entries.Add(new JournalEntry(prompt, response, date));
                }
            }

            Console.WriteLine("Your journal has been loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save: ");
        string saveFileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(saveFileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Your journal has been saved successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}