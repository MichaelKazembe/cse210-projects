public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title ) : base(studentName, topic)
    {
        _title = title;
    }

    // Getters
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $" {_title} by {studentName}";
    }
}