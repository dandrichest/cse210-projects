using System;

namespace Mindfulness;

public class BreathingActivity : Activity
{
    public void Run(int seconds)
    {
        DisplayStartingMessage("Breathing Activity", "This activity will guide you through calming breathing exercises.", seconds);

        int cycles = seconds / 10; // Each cycle is 10 seconds (4 seconds inhale + 6 seconds exhale)
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Inhale...");
            ShowCountDown(4); // Inhale for 4 seconds
            Console.WriteLine("Exhale...");
            ShowCountDown(6); // Exhale for 6 seconds
        }

        DisplayEndingMessage();
    }
}
