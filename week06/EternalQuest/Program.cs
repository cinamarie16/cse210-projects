using System;
using System.IO;
using System.Collections.Generic;
// I added levels to the gamification.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goals = new GoalManager();
        goals.Start();
    }
}