using System;

// Represents a journal entry
public class JournalEntry
{
    // Create a new journal entry
    public string _entry = "";
    public string _time = "";

    // Add a new journal entry
    public void AddEntry(string entry)
    {
        _entry = entry; // Set the entry to the user's input
        _time = DateTime.Now.ToString("MM/dd/yyyy"); // Set the time to the current date
    }
    
}

