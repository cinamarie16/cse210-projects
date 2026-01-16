using System;
using System.IO;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();

        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is one thing you learned today?");
        _prompts.Add("What was your mood today?");
        _prompts.Add("What was hard today?");
        _prompts.Add("Who did you talk to today?");

        
        int maxIndex = _prompts.Count;
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(1, maxIndex);
        int listIndex = randomIndex - 1;
        string prompt = _prompts[listIndex];
        return prompt;
    }
}