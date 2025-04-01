public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters
    public string GetSummary()
    {
        return $"{_studentName} submitted an assignment on {_topic}";
    }
}