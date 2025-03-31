using System.Collections.Generic;
public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();
    }

    // Getters
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Setters
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Methods
      public List<Comment> GetComments()
    {
        return _comments;
    }
}