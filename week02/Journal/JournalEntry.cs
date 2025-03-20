using System;

// Represents a single journal entry
public class JournalEntry
{
    public string _entry = "";
    public string _time = "";
    public string _prompt = "";
    public string _mood = ""; // Added mood tracking

    public void Entry(string prompt, string entry, string time, string mood)
    {
        _prompt = prompt;
        _entry = entry;
        _time = time;
        _mood = mood; // Set mood
    }

    public void DisplayEntry()
    {
        Console.WriteLine("Prompt: " + _prompt);
        Console.WriteLine("Entry: " + _entry);
        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Mood: " + _mood); // Display mood
        Console.WriteLine();
    }
}