using System;
using System.Formats.Asn1;

class Program
{
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

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            var randomQuestion = PromptQuestion._randomQuestionsPrompt();

            if (numberInput == "1")
            {
                Console.WriteLine("[" + dateText + "]");
                Console.WriteLine(randomQuestion);
                string dataEntry;
                dataEntry = Console.ReadLine();
                string filename = "journal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0];
                    string lastName = parts[1];
                }

                var randomQuestion = PromptQuestion._randomQuestionsPropmt();

            }
            else if (numberInput == "2")
            {
                Console.WriteLine("Your journal:");
                foreach(var entry in filename)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (numberInput == "3")
            {
                Console.WriteLine("");
            }
            else if (numberInput == "4")
            {
                Console.WriteLine("");
            }
            else if (numberInput == "5")
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Invalid. Please enter 1, 2, 3, 4, or 5.");
            }
        }
    }
}