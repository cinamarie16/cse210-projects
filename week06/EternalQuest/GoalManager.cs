using System.Runtime.CompilerServices;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _menuChoice;
    private string _goalType;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _menuChoice = "";
        _goalType = "";
    }

    public void Start()
    {
        Console.Clear();

        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Menu();

        } while (_menuChoice != "6");
    }

    private void Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
        _menuChoice = Console.ReadLine();

        if (_menuChoice == "1")
        {
            CreateGoal();
        }

        else if (_menuChoice == "2")
        {
            ListGoalDetails();
        }

        else if (_menuChoice == "3")
        {
            SaveGoals();
        }

        else if (_menuChoice == "4")
        {
            LoadGoals();
        }

        else if (_menuChoice == "5")
        {
            RecordEvent();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        string level = LevelCheck();
        if(level == "MAX")
        {
            Console.WriteLine($"Congratulations! You are a maximum level book dragon!");
        }

        else
        {
            Console.WriteLine($"You are a level {level} book dragon. Keep up the good work!");
            Console.WriteLine();
        }
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int goalIndex = 0;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalIndex + 1}. {goal.GetGoalName()}");
            goalIndex++;
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int goalIndex = 0;

        foreach (Goal goal in _goals)
        {
            string details = goal.GetDetailsString();
            Console.WriteLine($"{goalIndex + 1}. {details}");
            goalIndex++;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple goal");
        Console.WriteLine(" 2. Eternal goal");
        Console.WriteLine(" 3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        _goalType = Console.ReadLine();

        if (_goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("How many points are associated with this goal? ");
            string input1 = Console.ReadLine();
            int points = int.Parse(input1);

            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }

        else if (_goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("How many points are associated with this goal? ");
            string input1 = Console.ReadLine();
            int points = int.Parse(input1);

            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }

        else if (_goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("How many points are associated with this goal? ");
            string input1 = Console.ReadLine();
            int points = int.Parse(input1);

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string input2 = Console.ReadLine();
            int target = int.Parse(input2);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string input3 = Console.ReadLine();
            int bonus = int.Parse(input3);

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string input = Console.ReadLine();
        int goalIndex = int.Parse(input) - 1;
        int points = _goals[goalIndex].RecordEvent();
        _score = _score + points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        int index = 0;

        foreach (string line in lines)
        {
            if (index == 0)
            {
                _score = int.Parse(line);
            }

            else
            {
                string [] parts = line.Split("~|~");

                if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal simple = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(simple);
                }

                else if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal eternal = new EternalGoal(name, description, points);
                    _goals.Add(eternal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                   _goals.Add(checklist);
                }
            }
            index ++;
        }
    }

    private string LevelCheck()
    {
        string level = "0";
        if(_score > 0 && _score < 100)
        {
            level = "1";
            return level;
        }

        else if(_score >= 100 && _score < 250)
        {
            level = "2";
            return level;
        }

        else if(_score >= 250 && _score < 500)
        {
            level = "3";
            return level;
        }

        else if(_score >= 500 && _score < 1000)
        {
            level = "4";
            return level;
        }

        else if(_score >= 1000 && _score < 2000)
        {
            level = "5";
            return level;
        }

        else if(_score >= 2000)
        {
            level = "MAX";
            return level;
        }
        return level;
    }
}