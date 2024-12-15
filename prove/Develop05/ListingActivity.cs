public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Start()
    {
        ShowStartMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.Clear();
        Console.WriteLine(prompt);
        ShowPause();

        Console.WriteLine("Start listing now. Press Enter after each entry. Press Enter on an empty line to finish.");
        List<string> userResponses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
                break;
            userResponses.Add(response);
        }

        Console.WriteLine($"You listed {userResponses.Count} items.");
        ShowEndMessage("Listing Activity");
    }
}