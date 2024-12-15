using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        MindfulnessApp app = new MindfulnessApp();
        app.Start();
    }
}

public class MindfulnessApp
{
    public void Start()
    {
        bool continueApp = true;
        while (continueApp)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "4":
                    continueApp = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
