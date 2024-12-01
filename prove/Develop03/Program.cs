using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference and text
        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        
        // Initialize Scripture object
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(3); // Hides 3 random words
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Program will exit.");
    }
}
