using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        if ( guess < magicNumber )
        {
            Console.WriteLine("Guess Higher");
        }
        else if ( guess > magicNumber )
        {
            Console.WriteLine("Guess Lower");
        }
        else
        {
            Console.WriteLine("You guessed the magic number!");
        }
    }
}