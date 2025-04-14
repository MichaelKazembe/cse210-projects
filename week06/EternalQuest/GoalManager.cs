using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // This method can be used to start the program with any initial setup if needed
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        if (goal.IsComplete())
        {
            _score += goal.GetPoints();
        }
    }

    public Goal GetGoalByName(string name)
    {
        return _goals.FirstOrDefault(g => g.GetShortName().Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    string goalType = parts[0];

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
