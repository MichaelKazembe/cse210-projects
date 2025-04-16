using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 5.0), // 5 km
            new CyclingActivity(new DateTime(2022, 11, 3), 30, 20.0), // 20 km/h
            new SwimmingActivity(new DateTime(2022, 11, 3), 30, 40) // 40 laps
        };

        Console.Clear();

        // Display the summary of each activity
        Console.WriteLine("     EXERCISE TRACKING PROGRAM      ");
        Console.WriteLine("====================================\n");
        Console.WriteLine("******** Activities Summary ********\n");


        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        Console.WriteLine("====================================\n");
    }
}
