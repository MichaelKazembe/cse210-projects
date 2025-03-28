using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference for the scripture
        Reference scriptureReference = new Reference("John", 3, 16);

        // Create a scripture with the reference and text
        Scripture scripture = new Scripture(scriptureReference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Main loop to hide words and display the scripture
        while (true)
        {
            Console.Clear();                           // Clear the console screen
            Console.WriteLine(scriptureReference.GetDisplayText()); // Display the scripture reference
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture text with hidden words

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            // Prompt the user to press Enter or type 'quit'
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a few random words
            scripture.HideRandomWords(3);
        }
    }
}
