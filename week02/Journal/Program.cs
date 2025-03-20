using System;

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
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Enter Option: ");

            // Get the user's choice
            string choice = Console.ReadLine();

            // Process the user's choice using a switch statement
            switch (choice)
            {
                case "1":
                    // Display a random prompt
                    PromptGenerator prompt = new PromptGenerator();
                    prompt.DisplayPrompt();

                    // Add a Journal Entry
                    Console.Write("Enter your journal entry: ");
                    string userEntry = Console.ReadLine();

                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.AddEntry(userEntry);
                    journal.AddEntry(journalEntry);
                    Console.WriteLine("Journal Entry Added!");
                    Console.WriteLine();
                    break;

                case "2":
                    // Display all Journal Entries
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;

                case "3":
                    // Save the Journal to a File
                    Console.WriteLine("Saving the journal to a file...");
                    journal.SaveToFile();
                    Console.WriteLine();
                    break;

                case "4":
                    // Load the Journal from a File
                    Console.WriteLine("Loading the journal from a file...");
                    Console.WriteLine();
                    // Add logic for loading the journal
                    journal.LoadFromFile("journal.txt");
                    break;

                case "5":
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