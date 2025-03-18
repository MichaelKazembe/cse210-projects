using System;

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
}