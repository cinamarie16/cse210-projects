using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int numberGuess = -1;

        do
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Lower");
            }
        } while (numberGuess != magicNumber);

    }
}