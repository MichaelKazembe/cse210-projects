using System;

class Program
{
    static void Main(string[] args)
    {       
       
        DisplayWelcome();
        
        string userName = "";
        userName = PromptUserName(userName);

        int userNumber = 0;
        userNumber = UserNumber(userNumber);

        userNumber = SquareNumber(userNumber);
        DisplayResult(userName, userNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(string userName)
    {
        Console.Write("Please enter your name:");
        userName = Console.ReadLine();
        return userName;
    }

    static int UserNumber(int userNumber)
    {
        Console.Write("Please enter your favorite number:");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }


    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static void DisplayResult(string userName, int userNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {userNumber}.");
    }

}