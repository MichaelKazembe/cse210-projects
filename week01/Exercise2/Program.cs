using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        string letter = "";
        string positiveSign = "+";
        string negativeSign = "-";
        int modulus = 0;

        if (grade >= 90)
        {
            letter = "A";
            modulus = grade % 10;
            if (modulus >= 7)
            {
                Console.WriteLine($"You got an {letter}{positiveSign}");
            }

            else if (modulus <= 3)
            {
                Console.WriteLine($"You got an {letter}{negativeSign}");
            }

            else
            {
                Console.WriteLine($"You got an {letter}");
            }

        }

        else if (grade >= 80)
        {
            letter = "B";
            modulus = grade % 10;
            if (modulus >= 7)
            {
                Console.WriteLine($"You got an {letter}{positiveSign}");
            }

            else if (modulus <= 3)
            {
                Console.WriteLine($"You got an {letter}{negativeSign}");
            }

            else
            {
                Console.WriteLine($"You got an {letter}");
            }
        }

        else if (grade >= 70)
        {
            letter = "C";
            modulus = grade % 10;
            if (modulus >= 7)
            {
                Console.WriteLine($"You got an {letter}{positiveSign}");
            }

            else if (modulus <= 3)
            {
                Console.WriteLine($"You got an {letter}{negativeSign}");
            }

            else
            {
                Console.WriteLine($"You got an {letter}");
            }
        }

        else if (grade >= 60)
        {
            letter = "D";
            modulus = grade % 10;
            if (modulus >= 7)
            {
                Console.WriteLine($"You got an {letter}{positiveSign}");
            }

            else if (modulus <= 3)
            {
                Console.WriteLine($"You got an {letter}{negativeSign}");
            }

            else
            {
                Console.WriteLine($"You got an {letter}");
            }
        }

        else
        {
            letter = "F";
            Console.WriteLine($"You got an {letter}");
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