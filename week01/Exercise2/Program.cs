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
            string letter = "A";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade >= 80)
        {
            string letter = "B";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade >= 70)
        {
            string letter = "C";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade >= 60)
        {
            string letter = "D";
            Console.WriteLine($"You got an {letter}!");
        }
        else
        {
            string letter = "F";
            Console.WriteLine($"You got an {letter}!");
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