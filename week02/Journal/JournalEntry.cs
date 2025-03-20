using System;

// Represents a single journal entry
public class JournalEntry
{
    public string _entry = "";
    public string _time = "";
    public string _prompt = "";

    public void Entry(string prompt, string entry, string time)
    {
        _prompt = prompt;
        _entry = entry;
        _time = time;
    }

    public void DisplayEntry()
    {
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Entry: " + _entry);
        Console.WriteLine("Time: " + _time);
        Console.WriteLine();
    }
}


