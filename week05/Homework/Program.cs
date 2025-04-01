using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an object of the Assignment class

        Assignment assignment1= new Assignment("Michael", "C#");

        // Call the GetSummary method
        Console.WriteLine(assignment1.GetSummary());
    }
}