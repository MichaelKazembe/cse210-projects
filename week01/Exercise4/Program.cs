using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();

        Console.Write("Enter a series numbers. Enter 0 to stop: ");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number !=0)
            {
                numbers.Add(number);
                Console.WriteLine($"You entered {number}");
            }  

        }
        while (number != 0);

        int sum = 0; 
        int  max = int.MinValue;    
        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }
        }
        double average = (double)sum / numbers.Count; 

        Console.WriteLine($"The sum of numbers: {sum}");
        Console.WriteLine($"The average numbe: {average}");
        Console.WriteLine($"The largest number: {max}");
    }
}