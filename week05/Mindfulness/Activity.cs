using System.Collections.Generic;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        int GetDuration()
        {
            Console.Write($"\nHow long, in seconds, would you like for your session? ");
            string duration = Console.ReadLine();
            int durationInt = int.Parse(duration);
            return durationInt;
        }
        _duration = GetDuration();
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {        
        List<char> spinner = new List<char>(){'\\', '|', '/', '-'};
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        do
        {
            foreach (char s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
            
        } while (currentTime < futureTime);
    }

    public void ShowCountDown(int seconds)
    {
        int countDown = seconds;
        do
        {
            Console.Write(countDown);
            Thread.Sleep(1000);
            countDown = countDown - 1;
            Console.Write("\b \b");

        } while (countDown > 0);
    }
}