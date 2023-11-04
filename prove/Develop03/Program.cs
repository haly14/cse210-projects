using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me.");
        Console.WriteLine(scripture);

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideWords(3);
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
