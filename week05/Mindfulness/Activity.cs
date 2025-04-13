using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description} for {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        Logger.LogActivityStart(_name, _duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You have completed the {_name}.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine("End of activity.");
        Logger.LogActivityEnd(_name);
    }

    public abstract void Run();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Start!");
    }
}
