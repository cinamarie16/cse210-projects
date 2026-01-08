using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();
        int userNumber = -1;

        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}