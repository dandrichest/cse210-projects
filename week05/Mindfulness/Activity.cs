using System;

namespace Mindfulness;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    public void DisplayStartingMessage(string activityName, string description, int seconds)
    {
        _name = activityName;
        _description = description;
        _duration = seconds;

        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"The activity will last for {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Pause for 3 seconds with a spinner
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds. Great job!");
        ShowSpinner(3); // Pause for 3 seconds with a spinner
        Console.WriteLine("Well done!");
        ShowSpinner(2); // Pause for 2 seconds before finishing
    }

    public virtual void ShowSpinner(int seconds)
    {
        Console.Write("Processing"); // Text before the spinner
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("."); // Add dots for spinner effect
            System.Threading.Thread.Sleep(500); // Half-second delay
        }
        Console.WriteLine(); // Move to the next line after spinner completes
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // 1-second delay
        }
        Console.WriteLine("Time's up!");
    }
}
