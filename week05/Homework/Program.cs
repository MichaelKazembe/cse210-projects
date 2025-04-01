using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an object of the Assignment class

        Assignment assignment1= new Assignment("Michael", "C#");
        MathAssignment mathAssignment1 = new MathAssignment("Michael", "C#", "7.3", "8-19");

        // Call the GetSummary method
        Console.WriteLine(assignment1.GetSummary());

        // Call the GetHomeworkList method
        Console.WriteLine(mathAssignment1.GetHomeworkList());
    }
}