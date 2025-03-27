using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Reference
        Reference reference = new Reference("John", 3, 16);

        // Create a Scripture using the Reference and a text
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten Son");

        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press ENTER to hide random words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break; // Exit the program
            }
            else
            {
                // Hide a few random words
                scripture.HideRandomWords(3);

                // Check if all words are hidden
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nAll words are hidden! Goodbye!");
                    break; // Exit the program
                }
            }
        }
    }
}

// When selecting the random words to hide the program randomly select from only those words that are not already hidden.