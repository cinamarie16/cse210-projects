using System;
using System.IO;
using System.Collections.Generic;
// I thought it would be fun to add time tracking to the journal entries. That way,
// if someone adds more than one entry in a day, they can see what time each entry was made.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string menuChoice = "";
        Journal myJournal = new Journal();
        Entry entry = new Entry();
        for (int i = 0; menuChoice != "5"; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                myJournal.AddEntry(entry);
            }

            else if (menuChoice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (menuChoice == "3")
            // In the list of functional requirements, for #4 Load Journal from File,
            // it says it should "replace any entries currently stored in the journal."
            // However, if I had written an entry without loading my journal first,
            // that entry would be lost and that would annoy me. Instead, I made it 
            // so that loading a journal will add to what is currently stored in the journal.
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }

            else if (menuChoice == "4")
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }
        }
    }
}