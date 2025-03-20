using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a fraction to 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1}");

        // Initialize a fraction to 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {fraction2}");

        // Initialize a fraction to 3/4
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3: {fraction3}");

        // Get the top of fraction1
        fraction1.GetTop();
        Console.WriteLine($"Fraction 1 top: {fraction1.GetTop()}");

        // Get the bottom of fraction1
        fraction1.GetBottom();
        Console.WriteLine($"Fraction 1 bottom: {fraction1.GetBottom()}");

        // Set the top of fraction1 to 2
        fraction1.SetTop(2);
        Console.WriteLine($"Fraction 1 top: {fraction1.GetTop()}");

        // Set the bottom of fraction1 to 3
        fraction1.SetBottom(3);
        Console.WriteLine($"Fraction 1 bottom: {fraction1.GetBottom()}");
    }
}