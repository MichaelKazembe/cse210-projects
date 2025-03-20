using System;
using System.IO;
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
}