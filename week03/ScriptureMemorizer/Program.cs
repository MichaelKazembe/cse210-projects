using System;

/*
 * Extra Features Implemented:
 * 1. Manual Scripture Entry: Users can manually enter the book, chapter, start verse, and end verse,
 *    allowing for both single-verse and verse-range scriptures.
 * 2. Customizable Word Count: Users can specify the number of words to hide at a time,
 *    enhancing flexibility in the memorization process.
 * 3. Easy Reset: Users can reset the session to start over with the same scripture or enter a new one,
 *    providing a seamless way to practice multiple times without restarting the program.
 */


class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the scripture details
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        int chapter;
        Console.Write("Enter the chapter: ");
        while (!int.TryParse(Console.ReadLine(), out chapter)){
            Console.Write("Invalid input. Please enter a valid chapter number: ");
        }

        int startVerse;
        Console.Write("Enter the start verse: ");
        while (!int.TryParse(Console.ReadLine(), out startVerse)){
            Console.Write("Invalid input. Please enter a valid start verse number: ");
        }

        int endVerse;
        Console.Write("Enter the end verse (or the same as start verse for a single verse): ");
        while (!int.TryParse(Console.ReadLine(), out endVerse)){
            Console.Write("Invalid input. Please enter a valid end verse number: ");
        }

        // Create a reference for the scripture
        Reference scriptureReference = (startVerse == endVerse)
            ? new Reference(book, chapter, startVerse)
            : new Reference(book, chapter, startVerse, endVerse);

        // Prompt the user to enter the scripture text
        Console.Write("Enter the scripture text: ");
        string scriptureText = Console.ReadLine();

        // Create a scripture with the reference and text
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        // Prompt the user to enter the number of words to hide at a time
        int wordsToHide;
        Console.Write("Enter the number of words to hide at a time: ");
        while (!int.TryParse(Console.ReadLine(), out wordsToHide)){
            Console.Write("Invalid input. Please enter a valid number of words to hide: ");
        }

        // Main loop to hide words and display the scripture
        while (true){
            ClearConsole(); // Clear the console screen
            Console.WriteLine(scriptureReference.GetDisplayText()); // Display the scripture reference
            Console.WriteLine(scripture.GetDisplayText()); // Display the scripture text with hidden words

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden()){
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            // Prompt the user to press Enter or type 'quit' or 'reset'
            Console.WriteLine("\nPress Enter to hide more words, type 'reset' to restart, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit"){
                break;
            }
            else if (input.ToLower() == "reset"){
                // Reset the scripture
                scripture = new Scripture(scriptureReference, scriptureText);
                continue;
            }

            // Hide a few random words
            scripture.HideRandomWords(wordsToHide);
        }
    }

    // Method to clear the console
    static void ClearConsole(){
        Console.Clear();
    }
}
