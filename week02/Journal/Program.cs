using System;
/*
 * Summary of Changes to Exceed Requirements:
 * 
 * 1. Mood Tracking:
 *    - Added a `_mood` property to the `JournalEntry` class to track the user's mood for each entry.
 *    - Modified the `Entry` method in `JournalEntry` to include mood as a parameter.
 *    - Updated the `DisplayEntry` method to display the mood alongside the prompt, entry, and timestamp.
 *    - Updated file handling in `Journal.cs` to save and load the mood for each entry.
 * 
 * 2. Search Feature:
 *    - Added a `SearchEntries` method to the `Journal` class to allow users to search for entries by keyword.
 *    - The search checks the prompt, entry, time, and mood for matches (case-insensitive).
 *    - Added a new menu option (5) in `Program.cs` to enable users to search for entries.
 * 
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" *** Hello, Welcome to the Journal! *** ");
        Console.WriteLine();

        // Create a new Journal
        Journal journal = new Journal();

        while (true)
        {
            // Display the menu options
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine("1. Add a Journal Entry");
            Console.WriteLine("2. View Journal Entries");
            Console.WriteLine("3. Save the Journal to a File");
            Console.WriteLine("4. Load the Journal from a File");
            Console.WriteLine("5. Search Journal Entries");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter Option: ");

            // Get the user's choice
            string choice = Console.ReadLine();
            Console.WriteLine();

            // Process the user's choice using a switch statement
            switch (choice)
            {
                case "1":
                    // Display a random prompt
                    PromptGenerator prompt = new PromptGenerator();
                    string generatedPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine($"{generatedPrompt}");
        
                    // Get the user's journal entry
                    Console.Write("Enter your journal entry: ");
                    string userEntry = Console.ReadLine();
                    
                    // Get the user's mood
                    Console.Write("How are you feeling today? (e.g., Happy, Sad, Excited): ");
                    string mood = Console.ReadLine();
                    
                    // Record the time the entry was added
                    string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                    // Create a new Journal Entry
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.Entry(generatedPrompt, userEntry, time, mood);
                    journal.AddEntry(journalEntry);
                    Console.WriteLine("Journal Entry Added!");
                    journalEntry.DisplayEntry();
                    Console.WriteLine();
                    break;

                case "2":
                    // Display all Journal Entries
                    Console.WriteLine();
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayAll();
                    Console.WriteLine();
                    break;

                case "3":
                    // Save the Journal to a File
                    Console.WriteLine("Enter the file name to save the journal to: "); 
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    Console.WriteLine();
                    break;

                case "4":
                    // Load the Journal from a File
                    Console.WriteLine("Enter the file name to load the journal from: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    journal.DisplayAll();
                    Console.WriteLine();
                    break;

                case "5":
                    // Search for entries
                    Console.Write("Enter a keyword to search for: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    Console.WriteLine();
                    break;

                case "6":
                    // Exit the program
                    Console.WriteLine("Exiting... Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}