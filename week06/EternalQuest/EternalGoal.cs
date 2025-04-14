public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are recorded each time without completion
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}

