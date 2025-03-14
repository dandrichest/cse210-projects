using System;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal theJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            while (true)
            {
                Console.WriteLine("\nWelcome to the Journal Program!");
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": // Write a new entry
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Enter your response: ");
                        string entryText = Console.ReadLine();

                        Entry newEntry = new Entry(prompt, entryText);
                        theJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!");
                        break;

                    case "2": // Display all entries
                        Console.WriteLine("\nJournal Entries:");
                        theJournal.DisplayAll();
                        break;

                    case "3": // Load journal from a file
                        Console.Write("Enter file name to load from: ");
                        string loadFileName = Console.ReadLine();
                        theJournal.LoadFromFile(loadFileName);
                        break;

                    case "4": // Save journal to a file
                        Console.Write("Enter file name to save to: ");
                        string saveFileName = Console.ReadLine();
                        theJournal.SaveToFile(saveFileName);
                        break;

                    case "5": // Quit the program
                        Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }
    }
}


