using System;
using System.Collections.Generic;

namespace Mindfulness;

public class ReflectingActivity : Activity
{
    public List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Run(int seconds)
    {
        // Display the initial starting message
        DisplayStartingMessage("Reflecting Activity", "This activity will help you reflect on meaningful moments and experiences.", seconds);

        // Provide the user with a random prompt to reflect on
        Console.WriteLine("Please reflect on the following:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Take a moment to think about this before we continue...");
        ShowSpinner(3); // Provide a brief pause before continuing

        // Begin asking the user reflection questions
        DisplayQuestions(seconds);

        // Display the ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayQuestions(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds); // Calculate the time limit
        int questionIndex = 0;

        // Loop through questions, respecting the time limit
        while (DateTime.Now < endTime && questionIndex < _questions.Count)
        {
            // Display the question and wait for the user to prepare
            Console.WriteLine($"Question {questionIndex + 1}: {_questions[questionIndex]}");
            Console.WriteLine("Press Enter when you are ready to continue...");
            Console.ReadLine(); // Wait for the user to acknowledge

            // Show a spinner to simulate reflection time
            Console.WriteLine("Reflecting on this question...");
            ShowSpinner(2); // Spinner lasts for 2 seconds

            questionIndex++; // Move to the next question
        }

        // If all questions were answered
        if (questionIndex == _questions.Count)
        {
            Console.WriteLine("You've reflected on all the questions. Great job!");
        }
        else
        {
            Console.WriteLine("Time's up! You did great reflecting on the questions.");
        }
    }
}