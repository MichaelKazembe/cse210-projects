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
                    // Record the time the entry was added
                    string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                    // Create a new Journal Entry
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.Entry(generatedPrompt, userEntry, time);
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
                    Console.WriteLine("Loaded Entries:");
                    journal.DisplayAll();
                    Console.WriteLine();
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