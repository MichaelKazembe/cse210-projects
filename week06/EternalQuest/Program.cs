using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the GoalManager
        GoalManager goalManager = new GoalManager();

        // Main loop for the menu system
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    RecordEvent(goalManager);
                    break;
                case "3":
                    goalManager.ListGoalDetails();
                    break;
                case "4":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "5":
                    SaveGoals(goalManager);
                    break;
                case "6":
                    LoadGoals(goalManager);
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Eternal Quest Menu:");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. List all goals");
        Console.WriteLine("4. Display player info");
        Console.WriteLine("5. Save goals to file");
        Console.WriteLine("6. Load goals from file");
        Console.WriteLine("7. Exit");
        Console.Write("Choose an option: ");
    }

    static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter the number corresponding to the goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = goalType switch
        {
            "1" => new SimpleGoal(name, description, points),
            "2" => new EternalGoal(name, description, points),
            "3" => CreateChecklistGoal(name, description, points),
            _ => null
        };

        if (newGoal != null)
        {
            goalManager.CreateGoal(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type. Goal not created.");
        }
    }

    static Goal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter the target number of completions: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for reaching the target: ");
        int bonus = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, description, points, target, bonus);
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Which goal did you complete?");
        goalManager.ListGoalNames();
        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();

        Goal goalToRecord = goalManager.GetGoalByName(goalName);
        if (goalToRecord != null)
        {
            goalManager.RecordEvent(goalToRecord);
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to load the goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
        Console.WriteLine("Goals loaded successfully!");
    }
}
