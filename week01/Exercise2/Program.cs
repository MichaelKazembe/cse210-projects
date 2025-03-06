using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        string letter = "";
        string Sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            int modulus = grade % 10;
            if (modulus >= 7 && letter != "A")
            {
                Sign = "+";
            }
            else if (modulus <= 3)
            {
                Sign = "-";
            }
        }

        Console.WriteLine($"Your grade is {letter}{Sign}");

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