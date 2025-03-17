using System;

// Job class
// This class represents a job in a resume
public class Job 
{
    // Attributes
    // These attributes are public so they can be accessed from Program.cs
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // DisplayJobInformation method
    // This method displays the job information
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
