using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Console.Clear();
        Reference r1 = new("Proverbs", 3, 5, 6);
        Scripture s1 = new(r1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        // Reference r1 = new("Alma", 37, 6);
        // Scripture s1 = new(r1, "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");
        do
        {
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();
            
            // before hide random words, need to see if all words are hidden
            bool allHidden = s1.IsCompletelyHidden();
            if (allHidden == false)
            {
                s1.HideRandomWords(3);
            }
        } while (userInput != "quit");
    }
}