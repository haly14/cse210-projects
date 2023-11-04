using System;

public class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me.");
        scripture.HideWords(3); // Hide 3 random words initially
        Console.WriteLine(scripture);

        int wordsToHide = 3;
        bool quit = false;

        while (scripture.Reference.FullReference.Contains("_") && !quit)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideWords(wordsToHide);
                Console.Clear();
                Console.WriteLine(scripture);
            }
        }

        if (!quit)
        {
            Console.WriteLine("Now try to recite the entire scripture from memory!");
        }
    }
}
