using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        if (grade >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else 
        {
            Console.WriteLine("You got an F!");
        }

        if (grade >= 60)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
}