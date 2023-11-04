using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me.");
        Console.WriteLine(scripture);

        while (scripture.Text.Contains("_"))
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideWords(3); // Hide 3 random words
            Console.Clear();
            Console.WriteLine(scripture);
        }

        Console.WriteLine("Now try to recite the entire scripture from memory!");
    }
}
