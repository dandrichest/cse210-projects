using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Reference
        Reference reference = new Reference("John", 3, 16);

        // Create a Scripture using the Reference and a text
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten Son");

        // Display the Scripture
        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Hide random words
        scripture.HideRandomWords(5);

        // Display Scripture with some words hidden
        Console.WriteLine("Scripture with Hidden Words:");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Check if all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are hidden!");
        }
        else
        {
            Console.WriteLine("Some words are still visible.");
        }
    }
}
