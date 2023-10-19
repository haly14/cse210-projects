using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Philipians 4:13- I can do all things through Christ which strengtheneth me.");
        Console.WriteLine("Press enter to continue to type 'quit' to finish.");
        string userInput;
        userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.Clear();
            Console.WriteLine("Philipians 4:13- I can do ___ ______ through Christ which strengtheneth me.");
            Console.WriteLine("Press enter to continue to type 'quit' to finish.");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Philipians 4:13- I can do ___ ______ through ______ which _____________ me.");
            Console.WriteLine("Press enter to continue to type 'quit' to finish.");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Philipians 4:13- _ ___ do ___ ______ through ______ which _____________ __.");
            Console.WriteLine("Press enter to continue to type 'quit' to finish.");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Philipians 4:13- _ ___ __ ___ ______ _______ ______ _____ _____________ __.");
            Console.WriteLine("Now try to recite the entire scripture from memory!");
        }

        else if (userInput == "quit")
        {
            Console.WriteLine("If you would like to try again, please run the program again.");
        }
        
    }
}