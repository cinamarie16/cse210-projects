public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        do
        {
            Console.WriteLine();
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
            currentTime = DateTime.Now;

        } while (currentTime < futureTime);

        DisplayEndingMessage();
    }
}