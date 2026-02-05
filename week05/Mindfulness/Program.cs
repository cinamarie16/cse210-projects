using System;
using System.Collections.Generic;
// For extra creativity, I made it so that no random prompts/questions are repeated in that session

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity\n4. Quit");
            Console.Write("Select a number from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.Run();
            }

            else if (userChoice == "2")
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.Run();
            }

            else if(userChoice == "3")
            {
                ListingActivity l1 = new ListingActivity();
                l1.Run();
            }
            
        }while (userChoice != "4");
    }
}