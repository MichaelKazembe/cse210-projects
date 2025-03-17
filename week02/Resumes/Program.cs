using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a job object
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2018;

        // Display job information
        job1.DisplayJobInformation();

        // Create another job object
        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Product Manager";
        job2._startYear = 2018;
        job2._endYear = 2020;

        // Display job information
        job2.DisplayJobInformation();

        // Create a resume
        Resume myResume = new Resume();
        myResume._name = "Michael T. Kazembe";

        // Add jobs to the resume list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume information
        myResume.DisplayResumeInformation();
        
    }
}

