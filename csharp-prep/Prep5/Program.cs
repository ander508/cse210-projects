using System;


class Program
{
    static void Main(string[] args)
    
    {
        Student student = new Student();
        string name = student.GetName();
        // string number = student.GetNumber()
        
        Console.WriteLine(name);  
        Console.WriteLine(student.GetNumber());  
                
        Book book1 = new Book();
        book1.SetAuthor("Anderson");
        book1.SetTitle("A Great Book");
        
        Console.WriteLine(book1.GetBookInfo());
        
        
        
        
    //    DisplayWelcome();
       
    //    string userName = PromptUserName();
       
    //    int favoriteNumber = PromptUserNumber();
       
    //    int squaredNumber = SquareNumber(favoriteNumber);
       
    //    DisplayResult(userName, squaredNumber);
    // }
    // static void DisplayWelcome()
    // {
    //     Console.WriteLine("Welcome to the Program!");
    // }
    //  static string PromptUserName()
    // {
    //     Console.Write("Please enter your name: ");
    //     return Console.ReadLine();
    // }
    // static int PromptUserNumber()
    // {
    //     Console.Write("Please enter your favorite number: ");
    //     return int.Parse(Console.ReadLine());
    // }
    // static int SquareNumber(int number)
    // {
    //     return number * number;
    // }
    // static void DisplayResult(string name, int squaredNumber)
    // {
    //     Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}