public class BreathingActivity : Activity
{
    public override void Start()
    {
        ShowStartMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int timeRemaining = duration;
        while (timeRemaining > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowPause();
            Console.WriteLine("Breathe out...");
            ShowPause();
            timeRemaining -= 2; // Each breath cycle takes 2 seconds
        }

        ShowEndMessage("Breathing Activity");
    }
}
