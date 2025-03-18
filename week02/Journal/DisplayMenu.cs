using System;

public class DisplayMenu
{
    public void Display()
    {
        Console.WriteLine("Hello, Welcome to the Journal!");
        Console.WriteLine("Please Select an Option:");

        // Display the menu options
        Console.WriteLine("1. Add a Journal Entry");
        Console.WriteLine("2. View Journal Entries");
        Console.WriteLine("3. Save the Journal to a File");
        Console.WriteLine("4. Load the Journal from a File");
        Console.WriteLine("5. Exit");

        // Get the user's choice
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        // Process the user's choice
        
    }
}