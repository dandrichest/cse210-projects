using System;
using System.Collections.Generic;

namespace ExerciseTracking;

public abstract class Activity
{
    // Shared attributes
    private DateTime date;
    private int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public DateTime Date => date;
    public int DurationMinutes => durationMinutes;

    // Abstract methods for calculations
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method for summary
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} ({DurationMinutes} min): " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}