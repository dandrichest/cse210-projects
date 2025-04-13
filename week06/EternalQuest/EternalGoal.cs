using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(points)
    {
        _shortName = name;
        _description = description;
    }

    public override void RecordEvent(ref int score)
    {
        Console.WriteLine($"You earned {_points} points for completing this eternal goal!");
        score += _points;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _shortName = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
    }
}
