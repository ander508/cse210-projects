using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        
        // While loop
        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }
        
        
        // Do-While loop
        
        // string checkIn = "yes";
        
        // do{
        //     Console.Write("Are you checked in? ");
        //     checkIn = Console.ReadLine();
        // }
        // while (checkIn == "yes");
        
        
        //For Loop
        
        // for (int i = 0; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        
        
        // foreach Loop
        
        // List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        // foreach (string fruit in fruits)
        // {
        //     Console.WriteLine(fruit);
        // }
        
        // Random Number
        
        // Random randomGenerator  = new Random();
        
        // int randNumber = randomGenerator.Next(1,11);
        // Console.WriteLine(randNumber);
        
        
        // Prep 3 Assignment
        string playAgain = "yes";
        
        while (playAgain == "yes")
        {
            Random generateNumber = new Random();
        int magicNumber = generateNumber.Next(1, 101);
        Console.WriteLine(magicNumber);
        
        Console.Write("What is the magic number? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        int count = 1;
        // Console.WriteLine($"Counts:{count}");
        
        while (number != magicNumber)
        {
            if (number < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("Higher");
                
            }
            Console.Write("What is the magic number? ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            count += 1;
            // Console.WriteLine($"counts: {count}");
            
        }
        
        Console.WriteLine($"You are right, the number is: {magicNumber}");
        Console.WriteLine($"You guessed it correctly after: {count} guesses");
        Console.WriteLine("Do you want to play again? ");
        playAgain = Console.ReadLine();
        
        }
        
        
        
        
    }}