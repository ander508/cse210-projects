using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2050;
        Console.WriteLine(job1._company);
        job1.Display();
        
        
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2030;
        Console.WriteLine(job2._company);
        job2.Display();
        
        
        Resume resume1 = new Resume();
        resume1._name = "Anderson Offor";
        resume1._job.Add(job1);
        resume1._job.Add(job2);

        Console.WriteLine($"{resume1._job[0]._jobTitle}");
        Console.WriteLine($"{resume1._job[1]._jobTitle}");
        
        resume1.Display();
    }
    
}