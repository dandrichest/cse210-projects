using System;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nPlease select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunListingActivity();
                    break;
                case "3":
                    RunReflectingActivity();
                    break;
                case "4":
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        Console.Write("Enter the duration for the breathing activity in seconds: ");
        int seconds = GetValidDuration();

        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Run(seconds);
    }

    static void RunListingActivity()
    {
        Console.Write("Enter the duration for the listing activity in seconds: ");
        int seconds = GetValidDuration();

        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run(seconds);
    }

    static void RunReflectingActivity()
    {
        Console.Write("Enter the duration for the reflecting activity in seconds: ");
        int seconds = GetValidDuration();

        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run(seconds);
    }

    static int GetValidDuration()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                return seconds;
            }
            Console.Write("Invalid input. Please enter a positive number: ");
        }
    }
}

// Exceeding Requirement: Make sure no random prompts/questions are repeated until they have all been used at least once in that session.