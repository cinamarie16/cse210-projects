using System;
// I added the option to choose how many words you want to hide. I also added welcome and farewell messages.

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine();
        // Reference r1 = new("Proverbs", 3, 5, 6);
        // Scripture s1 = new(r1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        Reference r1 = new("Alma", 37, 6);
        Scripture s1 = new(r1, "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");
        
        int lengthOfScripture = s1.NumberOfWords();
        Console.WriteLine($"There are {lengthOfScripture} words in your scripture.");
        Console.WriteLine("How many words would you like to hide each round? (1-5) ");
        int numberToHide = int.Parse(Console.ReadLine());

        if (lengthOfScripture % numberToHide == 0)
        {
            do
            {
                Console.Clear();
                Console.WriteLine(s1.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish.");
                userInput = Console.ReadLine();
                
                bool allHidden = s1.IsCompletelyHidden();
                if (allHidden == false)
                {
                    s1.HideRandomWords(numberToHide);
                }
                else
                {
                    userInput = "quit";
                }
            } while (userInput != "quit");

            Console.WriteLine("Thank you for using the Scripture Memorizer Program.\n");
        }

        else
        {
            Console.WriteLine("You have chosen a number of words to hide that doesn't divide evenly.");
            Console.WriteLine("Please try again.\n");
        }
    }
}