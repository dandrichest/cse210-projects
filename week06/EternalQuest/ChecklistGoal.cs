using System;
using System.Collections.Generic;
using System.IO;
namespace EternalQuest;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(points)
    {
        _shortName = name;
        _description = description;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent(ref int score)
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal completed! You earned {_points + _bonus} points!");
            score += _points + _bonus;
        }
        else
        {
            Console.WriteLine($"You earned {_points} points for this event.");
            score += _points;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Completed {_amountCompleted}/{_target} times.";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _shortName = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _target = int.Parse(parts[4]);
        _bonus = int.Parse(parts[5]);
        _amountCompleted = int.Parse(parts[6]);
    }
}
