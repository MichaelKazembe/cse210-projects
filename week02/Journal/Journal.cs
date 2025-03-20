using System;
using System.Collections.Generic;

// Stores a list of journal entries
public class Journal
{
    // List of journal entries
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry newEntry)
    {
       _entries.Add(newEntry);
    }

    // Display all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    // Save journal to a file
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (JournalEntry entry in _entries)
                {
                    writer.WriteLine(entry._prompt);
                    writer.WriteLine(entry._entry);
                    writer.WriteLine(entry._time);
                    writer.WriteLine(entry._mood); // Save mood
                }
            }
            Console.WriteLine("Journal saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    // Load journal entries from a file
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    JournalEntry entry = new JournalEntry();
                    entry._prompt = reader.ReadLine();
                    entry._entry = reader.ReadLine();
                    entry._time = reader.ReadLine();
                    entry._mood = reader.ReadLine(); // Load mood
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }

    // Search for entries by keyword (prompt, entry, time, or mood)
    public void SearchEntries(string keyword)
    {
        var results = _entries.FindAll(entry =>
            entry._prompt.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            entry._entry.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            entry._time.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            entry._mood.Contains(keyword, StringComparison.OrdinalIgnoreCase)
        );

        if (results.Count == 0)
        {
            Console.WriteLine("No matching entries found.");
        }
        else
        {
            Console.WriteLine($"Found {results.Count} matching entries:");
            foreach (var entry in results)
            {
                entry.DisplayEntry();
            }
        }
    }
}