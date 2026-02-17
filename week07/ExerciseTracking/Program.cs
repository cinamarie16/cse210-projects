using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(30, 2);
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity(45, 10);
        activities.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity(60, 20);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}