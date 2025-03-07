using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = -1;

        while (guess != magicNumber )
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

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
                Console.WriteLine("You guessed the magic number!"); 
            }
        }
    }
}