using System;
using System.IO;

// Stores a list of journal entries
public class Journal
{
    // Create a new list of journal entries
    public List<JournalEntry> _entries = new List<JournalEntry>();
  

    // Add a new journal entry
    public void AddEntry(JournalEntry _entry)
    {
        _entries.Add(_entry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"-{entry._entry} (Time Added {entry._time})");
        }
    }

    // Save the journal to a file
    public void SaveToFile()
    {
        string fileName = "journal.txt";
        using(StreamWriter outputFile = new StreamWriter(fileName))
        { 
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._entry} (Time Added {entry._time})");
            }

        }
    }

    // Load the journal from a file
    public void LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach (var line in lines)
        {
            string[] parts = line.Split(" (Time Added ");

            JournalEntry entry = new JournalEntry();
            entry._entry = parts[0];
            entry._time = parts[1].TrimEnd(')');

            _entries.Add(entry);

            
        }
    }
}