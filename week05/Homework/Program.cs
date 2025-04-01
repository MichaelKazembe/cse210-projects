using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate objects
        Assignment assignment1 = new Assignment("Michael", "Fractions");
        MathAssignment mathAssignment1 = new MathAssignment("Michael", "Fractions", "7.3", "8-19");
        WritingAssignment writingAssignment1 = new WritingAssignment("Myers", "European History", "The Causes of World War");
        
        // Display assignment summaries and details
        Console.WriteLine("Assignment Summary:");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();
        
        Console.WriteLine("Math Assignment Homework List:");
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();
        
        Console.WriteLine("Writing Assignment Information:");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine();
    }
}