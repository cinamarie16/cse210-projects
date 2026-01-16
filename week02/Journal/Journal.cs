using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entry entry = new Entry();
    
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        // Setting the new time member variable
        entry._time = theCurrentTime.ToShortTimeString();

        PromptGenerator prompt = new PromptGenerator();
        entry._promptText = prompt.GetRandomPrompt();
        
        Console.WriteLine($"{entry._promptText}");
        Console.Write("> ");
        string entryText = Console.ReadLine();

        entry._entryText = entryText;

        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntries();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
        List<Entry> listName = _entries;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                // Including the new time member variable in the saved file
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._time}~|~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("~|~");

            entry._date = parts[0];
            entry._promptText = parts[1];
            // Loading the new time member variable from the file
            entry._time = parts[2];
            entry._entryText = parts[3];

            _entries.Add(entry);
        }
    }
}