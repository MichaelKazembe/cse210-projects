using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomMagicNumber = new Random();
        int magicNumber = randomMagicNumber.Next(1, 101);

        string playAgain = "";

        while (playAgain != "no")
        {
            int guess = -1;
            int countGuesses = 0;

            while (guess != magicNumber )
            {
                Console.Write("What is your guess?");
                
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

            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();
        }
    }
}