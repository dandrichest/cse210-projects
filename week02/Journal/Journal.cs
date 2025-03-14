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

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in _entries)
                {
                    // Get a random motivational quote
                    Random random = new Random();
                    string motivationalQuote = _motivationalQuotes[random.Next(_motivationalQuotes.Count)];

                    // Save the entry and motivational quote
                    writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                    writer.WriteLine($"Motivational Quote: {motivationalQuote}");
                    writer.WriteLine(); // Add a blank line for better readability
                }
            }
            Console.WriteLine("Journal saved successfully with motivational quotes!");
        }

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        var entry = new Entry(parts[1], parts[2]);
                        _entries.Add(entry);
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
