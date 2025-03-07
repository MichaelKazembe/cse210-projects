using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomMagicNumber = new Random();
        int magicNumber = randomMagicNumber.Next(1, 101);

        int guess = -1;
        int countGuesses = 0;

        while (guess != magicNumber )
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            countGuesses++;

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
                Console.WriteLine($"You have guessed {countGuesses} times");
            }

        }
    }
}