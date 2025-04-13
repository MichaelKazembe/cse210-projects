using System;
using System.Collections.Generic;

/*

EXCEEDING REQUIREMENTS:
Logging Feature: Records each activity session, including the type of activity, 
duration, and times. 
Then store sthis information in a text file for persistence.

*/

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("    * Mindfulness Program *   ");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.WriteLine("==============================");
        Console.Write("Select an activity (1-4): ");
    }

    static void RunBreathingActivity()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        Activity breathingActivity = new BreathingActivity("Breathing Activity", "Deep breathing exercise", duration);
        breathingActivity.Run();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void RunReflectionActivity()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult."
        };
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?"
        };
        Activity reflectionActivity = new ReflectingActivity("Reflection Activity", "Reflect on past experiences", duration, prompts, questions);
        reflectionActivity.Run();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void RunListingActivity()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?"
        };
        Activity listingActivity = new ListingActivity("Listing Activity", "List positive things", duration, 5, prompts);
        listingActivity.Run();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
}
