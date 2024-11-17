using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        // Console.WriteLine("Hello Prep2 World!");
        // Console.Write("What is your favorite number? ");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);
        
        // Console.WriteLine(number);
        
        // Console.Write("Enter a number? ");
        // string num = Console.ReadLine();
        // int x = int.Parse(num);
        // int y = 20;
        
        // if (x > y)
        // {
        //     Console.WriteLine("Greater");
        // }
        // else if (x < y)
        // {
        //     Console.WriteLine("Less");
        // }
        // else {
        //     Console.WriteLine("Equal");
        // }
        
        
         Console.Write("Enter Score? ");
        string scoreEnteredByUser = Console.ReadLine();
        int score = int.Parse(scoreEnteredByUser);
        string grade;
        
        if (score >= 90)
        {
           
            if ((score - 90) < 3)
            {
            grade = "A-";
                
            }
            else{
            grade = "A";
                
            }
        }
        else if (score >= 80)
        {
            if ((score - 80) >= 7)
            {
            grade = "B+";
                
            }
            else if ((score - 80) < 3)
            {
            grade = "B-";
                
            }
            else{
            grade = "B";
                
            }
        }
        else if (score >= 70)
        {
             if ((score - 70) >= 7)
            {
            grade = "C+";
                
            }
            else if ((score - 70) < 3)
            {
            grade = "C-";
                
            }
            else{
            grade = "C";
                
            }
        }
        else if (score >= 60)
        {
            if ((score - 60) >= 7)
            {
            grade = "D+";
                
            }
            else if ((score - 60) < 3)
            {
            grade = "D-";
                
            }
            else{
            grade = "D";
                
            }
        }
        else{
           grade = "F";
            
        }
        
        Console.WriteLine(grade);
        
        if (score >= 70)
        {
            Console.WriteLine("Passed");
            
        }
        else
        {
            Console.WriteLine("Try Again");
            
        }
        
        
    }
}