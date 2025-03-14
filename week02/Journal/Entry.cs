using System;

namespace Journal
{
    public class Entry
    {
        public DateTime _date { get; set; }
        public string _promptText { get; set; }
        public string _entryText { get; set; }

        public Entry(string promptText, string entryText)
        {
            _date = DateTime.Now; // Set the current date and time
            _promptText = promptText;
            _entryText = entryText;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}\n");
        }
    }
}
