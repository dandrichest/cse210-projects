using System;
using System.Collections.Generic;

namespace Mindfulness;

public class ListingActivity : Activity
{
    public int _count;
    public List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run(int seconds)
    {
        // Display the starting message
        DisplayStartingMessage("Listing Activity", "This activity will help you list positive experiences or moments.", seconds);

        // Choose a random prompt and display it
        Console.WriteLine("Consider the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You have as much time as you set to list responses. Start now!");

        // Collect responses within the time limit
        List<string> responses = GetListFromUser(seconds);
        _count = responses.Count;

        Console.WriteLine($"You listed {_count} items. Great job!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser(int seconds)
    {
        List<string> responses = new List<string>();
        Console.WriteLine($"You have {seconds} seconds to list as many responses as you can. Go!");

        DateTime endTime = DateTime.Now.AddSeconds(seconds); // Calculate when to stop

        // Accept responses as long as time is not up
        while (DateTime.Now < endTime)
        {
            Console.Write("> "); // Indicate input
            string input = Console.ReadLine();

            // Check if the input is valid and record it
            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
            }
        }

        // Inform the user that time has expired
        Console.WriteLine("Time's up!");
        return responses;
    }
}
