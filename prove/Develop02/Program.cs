using System;

public class Program
{
    public static Journal journal = new Journal();
    public static PromptGenerator promptGenerator = new PromptGenerator();

    public static void Main(string[] args)
    {
    string choice = "";

    while (choice != "5")
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            WriteNewEntry();
        }
        else if (choice == "2")
        {
            journal.DisplayAll();
        }
        else if (choice == "3")
        {
            SaveJournal();
        }
        else if (choice == "4")
        {
            LoadJournal();
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
        }

    public static void WriteNewEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        journal.AddEntry(new Entry(prompt, response));
    }

    public static void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    public static void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
