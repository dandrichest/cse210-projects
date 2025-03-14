using System;

namespace Journal
{
    public class Entry
    {
        public DateTime _date { get; set; }
        public string _promptText { get; set; }
        public string _entryText { get; set; }

        // Constructor to initialize an Entry
        public Entry(string promptText, string entryText)
        {
            _date = DateTime.Now;        // Set the current date and time
            _promptText = promptText;   // Prompt text for the entry
            _entryText = entryText;     // User's response to the prompt
        }

        // Display entry details
        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
            Console.WriteLine(); // Add a blank line for readability
        }
    }
}
