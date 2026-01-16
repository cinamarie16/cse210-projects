using System;
using System.IO;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    // I added a new member variable for the time
    public string _time;


    public void DisplayEntries()
    {
        Console.WriteLine();
        Console.WriteLine($"Prompt: {_promptText}");
        // Using the new member variable to display the time
        Console.WriteLine($"Date: {_date} - {_time}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}