using System;
using System.Collections.Generic;

namespace ExerciseTracking;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0;

    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / GetDistance();

    public override string GetSummary()
    {
        return $"Swimming: " + base.GetSummary();
    }
}