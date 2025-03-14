using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Journal
    {
        public List<Entry> _entries { get; set; } = new List<Entry>();

        // List of motivational quotes
        private readonly List<string> _motivationalQuotes = new List<string>
        {
            "Keep pushing forward no matter what!",
            "Every day is a new opportunity to grow.",
            "Believe in yourself and all that you are.",
            "You are stronger than you think.",
            "Success is the sum of small efforts repeated day in and day out."
        };

        // Add a new entry to the journal
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        // Display all entries in the journal
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No journal entries to display.");
                return;
            }

            Random random = new Random(); // Create a random instance for motivational quotes

            foreach (var entry in _entries)
            {
                entry.Display(); // Display the entry details

                // Display a random motivational quote
                string motivationalQuote = _motivationalQuotes[random.Next(_motivationalQuotes.Count)];
                Console.WriteLine($"Motivational Quote: {motivationalQuote}");
                Console.WriteLine(); // Add a blank line for readability
            }
        }


        // Save journal entries to a file with motivational quotes
        public void SaveToFile(string fileName)
        {
            Random random = new Random(); // Create a single Random instance

            using (StreamWriter writer = new StreamWriter(fileName, false)) // Overwrite the file
            {
                foreach (var entry in _entries)
                {
                    // Get a random motivational quote
                    string motivationalQuote = _motivationalQuotes[random.Next(_motivationalQuotes.Count)];

                    // Write the entry and motivational quote to the file
                    writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                    writer.WriteLine($"Motivational Quote: {motivationalQuote}");
                    writer.WriteLine(); // Add a blank line for readability
                }
            }

            Console.WriteLine("Journal saved successfully with motivational quotes!");
        }


        // Load journal entries from a file
        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                _entries.Clear(); // Clear the current list to avoid duplication
                string[] lines = File.ReadAllLines(fileName);

                for (int i = 0; i < lines.Length; i += 3) // Process entries in chunks (date, text, quote)
                {
                    if (i < lines.Length - 2) // Ensure we don’t go out of bounds
                    {
                        string[] parts = lines[i].Split(',');

                        if (parts.Length >= 3)
                        {
                            string prompt = parts[1].Trim();
                            string text = parts[2].Trim();
                            var entry = new Entry(prompt, text);
                            _entries.Add(entry);
                        }
                    }
                }

                Console.WriteLine("Journal loaded successfully!");
            }
            else
            {
                Console.WriteLine($"Error: File \"{fileName}\" not found.");
            }
        }

    }
}
