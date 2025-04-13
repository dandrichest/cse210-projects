using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest;

// Base class for Goals
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected Goal(int points)
    {
        _points = points;
    }

    public abstract void RecordEvent(ref int score);
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }
    public abstract string GetStringRepresentation();
    public abstract void LoadFromString(string data);

    // Public property for accessing _points
    public int Points => _points;
}

