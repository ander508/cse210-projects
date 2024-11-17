// using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // List<string> fruits = new List<string>();
        // fruits.Add("Apple");
        // fruits.Add("Orange");
        // fruits.Add("Mango");
        // fruits.Add("Pawpaw");
        
        // foreach (string fruit in fruits){
        //     Console.WriteLine(fruit);
            
        // }
        
        //     if (fruits.Contains("Apple"))
        //     {
        //         Console.WriteLine($"Apple is in the list");
                
        //     }
        //     else{
        //         Console.WriteLine($"Apple is not in the list");
                
        //     }
           
        // int length = fruits.Count;
        // Console.WriteLine(length);
        // for (int i = 0; i <= fruits.Count-1; i++)
        // {
        //     Console.WriteLine(fruits[i]);
        // }
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = 1;
        List<int> values = new List<int>();
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            
            if (number != 0)
            {
                values.Add(number);
            }
        }
        
        int sum  = 0;
        foreach (int value in values){
            sum += value;
        }
        int length = values.Count;
        double avg = (float)sum /length;
        int max  = values.Max();
        Console.WriteLine(string.Join(",", values));
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg:F2}");
        Console.WriteLine($"The largest number is: {max}");
    }
}