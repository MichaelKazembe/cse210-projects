using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        List<string> items = GetListFromUser();

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        return items;
    }
}
