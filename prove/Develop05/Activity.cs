public abstract class Activity
{
    protected int duration;

    public abstract void Start();

    protected void ShowStartMessage(string activityName, string description)
    {
        Console.Clear();
        Console.WriteLine($"{activityName} - {description}");
        Console.Write("Please enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    protected void ShowEndMessage(string activityName)
    {
        Console.Clear();
        Console.WriteLine($"Great job! You've completed the {activityName} activity.");
        Console.WriteLine($"Duration: {duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void ShowPause()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}