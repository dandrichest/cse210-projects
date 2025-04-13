using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(points)
    {
        _shortName = name;
        _description = description;
        _completed = false;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_completed)
        {
            Console.WriteLine($"You earned {_points} points for completing this goal!");
            score += _points;
            _completed = true;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_completed}";
    }

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _shortName = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _completed = bool.Parse(parts[4]);
    }
}
