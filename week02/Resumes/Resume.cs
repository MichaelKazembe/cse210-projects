using System;

// Resume class
// This class represents a resume with multiple jobs
public class Resume
{
    // Attributes
    // These attributes are public so they can be accessed from Program.cs
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeInformation()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInformation();
        }
    }


}