using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        do
        {
            GetListFromUser();
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);

        int count = _responses.Count();
        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        return prompt;
    }

    private List<string> GetListFromUser()
    {        
        Console.Write("> ");
        string response = Console.ReadLine();
        _responses.Add(response);
        return _responses;
    }
}