public class Comment
{
    private string _commenterName;
    private string _comment;

    // Constructor
    public Comment(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }

    // Getters
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetComment()
    {
        return _comment;
    }
}