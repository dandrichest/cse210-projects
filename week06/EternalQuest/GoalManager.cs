using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private DateTime _lastLoginDate;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            ApplyDailyBonus();

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void ApplyDailyBonus()
    {
        DateTime currentDate = DateTime.Now.Date;
        if (_lastLoginDate != currentDate)
        {
            const int dailyBonus = 100; // Daily bonus points
            _score += dailyBonus;
            _lastLoginDate = currentDate;

            Console.WriteLine($"Daily login bonus applied: +{dailyBonus} points!");
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Last Login Date: {_lastLoginDate.ToShortDateString()}");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple/Eternal/Checklist):");
        string type = Console.ReadLine().ToLower();

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points:");
        int points = int.Parse(Console.ReadLine());

        if (type == "simple")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "eternal")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "checklist")
        {
            Console.WriteLine("Enter target:");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter bonus points:");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal.GetDetailsString().Contains(name))
            {
                goal.RecordEvent(ref _score);
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_lastLoginDate.ToString()); // Save the last login date
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            _goals.Clear();

            // Load the last login date
            _lastLoginDate = DateTime.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                var parts = line.Split('|');
                string type = parts[0];

                Goal goal = type switch
                {
                    "SimpleGoal" => new SimpleGoal("", "", 0),
                    "EternalGoal" => new EternalGoal("", "", 0),
                    "ChecklistGoal" => new ChecklistGoal("", "", 0, 0, 0),
                    _ => null
                };

                if (goal != null)
                {
                    goal.LoadFromString(line);
                    _goals.Add(goal);
                }
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}

